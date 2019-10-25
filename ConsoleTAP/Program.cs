using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace ConsoleTAP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            #region Параллельное программирование

            //PrintInfoAsync("Основной поток начат");

            ////var task1 = Task.Run(() => PrintInfoAsync("task1"));

            ////task1.Wait();

            //var tasks = Enumerable.Range(1, 11).Select(o => Task.Run(() =>
            //{
            //    //Thread.Sleep(1000);
            //    //Console.WriteLine($"№ {o: 3}, task {Task.CurrentId: 3}, Thread {Thread.CurrentThread.ManagedThreadId: 3}");
            //    PrintInfoAsync($"№ {o :D2}");
            //})).ToArray();

            //Task t2 = Task.WhenAny(tasks);
            //Task<int> t3 = t2.ContinueWith(t =>
            //{
            //    PrintInfoAsync($"Статус {t.Status}");
            //    return Task.CurrentId ?? 0;
            //});

            //var factory = new TaskFactory<int>();

            //var t4 = factory.StartNew(p =>
            //{
            //    PrintInfoAsync($"Через фабрику, задача {(p as Task)?.Id}, статус {(p as Task)?.Status}");
            //    return Task.CurrentId ?? 0;
            //}, t2, TaskCreationOptions.LongRunning);

            //t4.ContinueWith(t => PrintInfoAsync(t.Result.ToString()));

            //PrintInfoAsync($"Закончено выполнение задачи {t3.Result}");

            //PrintInfoAsync("Основной поток завершён");

            //Console.WriteLine("\n\nParallel");

            //Parallel.For(1, 11, (i, p) => PrintInfoAsync($"i = {i}, loop = {p}"));

            //PrintInfoAsync("Основной поток завершён");


            //Console.WriteLine("\n\nParallelLINQ");

            //Enumerable.Range(1, 30).AsParallel().Select(i =>
            //{
            //    PrintInfoAsync(i.ToString());
            //    return i;
            //}).ToArray();

            //PrintInfoAsync("Основной поток завершён");


            #endregion


            //Console.WriteLine("\n\nAsync");

            //PrintInfoAsync("Основной поток начат");

            //Func<string, int> func = PrintInfoIntAsync;

            //func.Invoke("Invoke");

            //func.BeginInvoke("BeginInvoke", ar => PrintInfoAsync($"EndInvoke result: {func.EndInvoke(ar)}"), null);

            //var resAsync = func.BeginInvoke("BeginInvoke2", ar => PrintInfoAsync("BeginInvoke2 завершился"), null);

            //PrintInfoAsync($"Текущий статус завершения BeginInvoke2: {resAsync.IsCompleted}");

            //var result = func.EndInvoke(resAsync);

            //PrintInfoAsync($"Получили результат EndInvoke2 в основном потоке: {result}");

            //PrintInfoAsync("Основной поток завершён");

            PrintInfo("Основной поток начат");

            //IEnumerable<int> alexsInts = Enumerable.Range(1, 20);
            //alexsInts.Print(nameof(alexsInts));
            //var transformed = from x in alexsInts
            //    where x != 9
            //    select x + 2;
            //transformed.Print(nameof(transformed));

            //ModifyData(alexsInts);

            ConcoleOut();

            for (int i = 0; i < 30; i++)
            {
                await Task.Delay(500);
                //await Delay(500);
                Console.WriteLine($"Что-то делаем {i}");
            }
            

                    Console.ReadLine();
        }

        private static Task Delay(int millisec)
        {
            TaskCompletionSource<object> tcs = new TaskCompletionSource<object>();
            Timer timer = new Timer(t => tcs.SetResult(null), null, millisec, Timeout.Infinite);
            tcs.Task.ContinueWith(t => timer.Dispose());
            return tcs.Task;
        }

        private static async void ConcoleOut()
        {
            if (await GetUserPremission())
            {
                Console.WriteLine("Получен положительный ответ");
            }
            else
            {
                Console.WriteLine("Получен отрицательный ответ");
            }
        }

        private static async Task PrintInfoAsync(string str = null)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Задача: {Task.CurrentId :D2}, Поток {Thread.CurrentThread.ManagedThreadId :D2}, {str}");
        }

        private static void PrintInfo(string str = null)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Задача: {Task.CurrentId:D2}, Поток {Thread.CurrentThread.ManagedThreadId:D2}, {str}");
        }

        private static async Task<int> PrintInfoIntAsync(string str = null)
        {
            Thread.Sleep(1000);
            await PrintInfoAsync(str + " innerCall");
            Console.WriteLine($"Задача: {Task.CurrentId:D2}, Поток {Thread.CurrentThread.ManagedThreadId:D2}, {str}");
            return Task.CurrentId ?? 1;
        }

        private static async void ModifyData(IEnumerable<int> list)
        {
            IEnumerable<int> transformed;
            IEnumerable<Task<int>> tasks = list
                .Where(x => x != 9)
                .AsParallel()
                .Select(async x => await PrintInfoIntAsync($"{x} call 1") + await PrintInfoIntAsync($"{x} call 2"))
                .ToArray();
            transformed = await Task.WhenAll(tasks);
            transformed.Print(nameof(transformed) + " await");
        }

        [STAThread]
        public static Task<bool> GetUserPremission()
        {
            TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();

            var t1 = Task.Run(() =>
                {
                    PrintInfo("Dialog");
                    return MessageBox.Show("Согласны?", "Вопрос", MessageBoxButton.YesNo, MessageBoxImage.Question);
                }
                );
            t1.ContinueWith(r =>
            {
                PrintInfo("Result");
                tcs.SetResult(r.Result == MessageBoxResult.Yes);
            });

            PrintInfo("GetUserPremission");    
            
            return tcs.Task;
        }
    }

    public static class Extentions
    {
        public static void Print<T>(this IEnumerable<T> list, string name = null)
        {
            Console.Write($"{name ?? list.GetType().Name}: count {list.Count()}, values: ");
            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}
