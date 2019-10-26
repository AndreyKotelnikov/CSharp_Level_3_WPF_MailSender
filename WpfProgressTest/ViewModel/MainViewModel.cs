using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MailSender.Lib.MVVM;
using Microsoft.Win32;

namespace WpfProgressTest.ViewModel
{
    public class MainViewModel : MailSender.Lib.MVVM.ViewModel
    {
        public MainViewModel()
        {
            ComputeSummCommand = new LamdaCommand(OnComputeSummExecuteAsync, CanComputeSummExecute);
            CancelComputeSummCommand = new LamdaCommand(OnCancelComputeSummExecuteAsync, CanCancelComputeSummExecute);
            OpenFileCommand = new LamdaCommand(OnOpenFileCommandExecute, CanOpenFileCommandExecute);
        }


        private string _text;

        public string Text
        {
            get => _text;
            set => Set(ref _text, value);
        }

        
        private bool CanOpenFileCommandExecute(object arg) => true;
        

        private async void OnOpenFileCommandExecute(object obj)
        {
            var dialog = new OpenFileDialog
            {
                Title = "Выбрать файл для анализа слов",
                Filter = "Архивы (*.zip)|*.zip|Текстовые файлы (*.txt)|*.txt"
            };

            if (dialog.ShowDialog() != true)
            {
                return;
            }

            var fileName = dialog.FileName;

            switch (Path.GetExtension(fileName).ToLower())
            {
                case ".zip":
                    Text = string.Join("\n",await Task.Run(() => ParseZip(fileName)) );
                    break;
                case ".txt":
                    break;
            }
        }

        private async Task<List<string>> ParseZip(string fileName)
        {
            //Thread.Sleep(5000);
            var strList = new List<string>();
            using (var file = File.OpenRead(fileName))
            using (var zip = new ZipArchive(file, ZipArchiveMode.Read))
            {
                foreach (var zipArchiveEntry in zip.Entries)
                {
                    strList.AddRange(await ParseZipEntry(zipArchiveEntry).ConfigureAwait(false));
                }
            }

            return strList;
        }

        private async Task<List<string>> ParseZipEntry(ZipArchiveEntry zipArchiveEntry)
        {
            Thread.Sleep(5000);
            var strList = new List<string>();
            using (var stream = zipArchiveEntry.Open())
            using (var reader = new StreamReader(stream, Encoding.UTF8))
                while (!reader.EndOfStream)
                {
                    var str = await reader.ReadLineAsync();
                    strList.Add(str);
                }

            return strList;
        }




        #region Progress

        private int _result;

        public int Result
        {
            get => _result;
            set => Set(ref _result, value);
        }

        private double _computeProgress;

        public double ComputeProgress
        {
            get => _computeProgress;
            set => Set(ref _computeProgress, value);
        }


        public ICommand ComputeSummCommand { get; }

        private bool _canComputeSummExecute = true;

        public ICommand CancelComputeSummCommand { get; }

        

        private void OnCancelComputeSummExecuteAsync(object obj) => _cancellationTokenSource?.Cancel();


        private CancellationTokenSource _cancellationTokenSource;

        private bool CanComputeSummExecute(object obj) => _canComputeSummExecute;

        private bool CanCancelComputeSummExecute(object obj) => _cancellationTokenSource != null;

        private async void OnComputeSummExecuteAsync(object obj)
        {
            _canComputeSummExecute = false;
            ComputeProgress = 0;
            _cancellationTokenSource = new CancellationTokenSource();
            IProgress<(double, int)> progress = new Progress<(double, int)>(p =>
            {
                ComputeProgress += p.Item1;
                Result = p.Item2;
            });

            Task<int> task = ComputeSummAsync(100, 500, _cancellationTokenSource.Token, progress);

            try
            {
                Result = await task;
            }
            catch (OperationCanceledException e)
            {
                Task.Run(() => MessageBox.Show(e.Message, "Error:"));
                Result = 0;
                ComputeProgress = 0;
            }
            catch (AggregateException e)
            {
                foreach (Exception exception in e.InnerExceptions)
                {
                    if (exception is OperationCanceledException /*|| exception?.InnerException is OperationCanceledException*/)
                    {
                        Result = 0;
                        ComputeProgress = 0;
                    }
                    else
                    {
                        Task.Run(() => MessageBox.Show(exception.Message, "Error:"));
                    }
                }
            }
            _canComputeSummExecute = true;
            _cancellationTokenSource = null;
            CommandManager.InvalidateRequerySuggested();
        }

        private async Task<int> ComputeSummAsync(int end, int delay, CancellationToken cancellationToken = default,
            IProgress<(double, int)> progress = null)
        {
            return await Task.Run(() => ComputeSumm(end, delay, cancellationToken, progress));
        }

        private static int ComputeSumm(int end, int delay, CancellationToken cancellationToken = default, IProgress<(double, int)> progress = null)
        {
            var result = 0;
            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.CancellationToken = cancellationToken;
            ParallelLoopResult loopResult;

            loopResult = Parallel.For(1,
                end + 1,
                parallelOptions,
                (i, s) =>
                {
                    //if (cancellationToken.IsCancellationRequested)
                    //{
                    //    s.Stop();
                    //}
                    //cancellationToken.ThrowIfCancellationRequested();
                    Interlocked.Add(ref result, i);
                    Task.Delay(delay).Wait();
                    progress?.Report(((double)1 / end, result));
                });
           

            

            //for (int i = 0; i <= end; i++)
            //{
            //    cancellationToken.ThrowIfCancellationRequested();
            //    result += i;
            //    Task.Delay(delay, cancellationToken).Wait();
            //    progress?.Report(((double)i / end, result));
            //}
            //throw new ArgumentNullException("progress", "Finished");
            return result;
        }

        #endregion

        public ICommand OpenFileCommand { get; }

    }
}
