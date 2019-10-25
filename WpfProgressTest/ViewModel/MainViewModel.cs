using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MailSender.Lib.MVVM;

namespace WpfProgressTest.ViewModel
{
    public class MainViewModel : MailSender.Lib.MVVM.ViewModel
    {
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

        public MainViewModel()
        {
            ComputeSummCommand = new LamdaCommand(OnComputeSummExecuteAsync, CanComputeSummExecute);
            CancelComputeSummCommand = new LamdaCommand(OnCancelComputeSummExecuteAsync, CanCancelComputeSummExecute);
        }

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
            catch (AggregateException e)
            {
                foreach (Exception exception in e.InnerExceptions)
                {
                    if (exception is OperationCanceledException || exception?.InnerException is OperationCanceledException)
                    {
                        Result = 0;
                        ComputeProgress = 0;
                        //CommandManager.InvalidateRequerySuggested();
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
            //ParallelOptions parallelOptions = new ParallelOptions();
            //parallelOptions.CancellationToken = cancellationToken;

            Parallel.For(1,
                end + 1,
                (i, s) =>
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    Interlocked.Add(ref result, i);
                    Task.Delay(delay, cancellationToken).Wait();
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
    }
}
