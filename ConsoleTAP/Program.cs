using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleTAP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Параллельное программирование

            //PrintInfo("Основной поток начат");

            ////var task1 = Task.Run(() => PrintInfo("task1"));

            ////task1.Wait();

            //var tasks = Enumerable.Range(1, 11).Select(o => Task.Run(() =>
            //{
            //    //Thread.Sleep(1000);
            //    //Console.WriteLine($"№ {o: 3}, task {Task.CurrentId: 3}, Thread {Thread.CurrentThread.ManagedThreadId: 3}");
            //    PrintInfo($"№ {o :D2}");
            //})).ToArray();

            //Task t2 = Task.WhenAny(tasks);
            //Task<int> t3 = t2.ContinueWith(t =>
            //{
            //    PrintInfo($"Статус {t.Status}");
            //    return Task.CurrentId ?? 0;
            //});

            //var factory = new TaskFactory<int>();

            //var t4 = factory.StartNew(p =>
            //{
            //    PrintInfo($"Через фабрику, задача {(p as Task)?.Id}, статус {(p as Task)?.Status}");
            //    return Task.CurrentId ?? 0;
            //}, t2, TaskCreationOptions.LongRunning);

            //t4.ContinueWith(t => PrintInfo(t.Result.ToString()));

            //PrintInfo($"Закончено выполнение задачи {t3.Result}");

            //PrintInfo("Основной поток завершён");

            //Console.WriteLine("\n\nParallel");

            //Parallel.For(1, 11, (i, p) => PrintInfo($"i = {i}, loop = {p}"));

            //PrintInfo("Основной поток завершён");


            //Console.WriteLine("\n\nParallelLINQ");

            //Enumerable.Range(1, 30).AsParallel().Select(i =>
            //{
            //    PrintInfo(i.ToString());
            //    return i;
            //}).ToArray();

            //PrintInfo("Основной поток завершён");


            #endregion


            Console.WriteLine("\n\nAsync");

            PrintInfo("Основной поток начат");

            Func<string, int> func = PrintInfoInt;

            func.Invoke("Invoke");

            func.BeginInvoke("BeginInvoke", ar => PrintInfo($"EndInvoke result: {func.EndInvoke(ar)}"), null);

            var resAsync = func.BeginInvoke("BeginInvoke2", ar => PrintInfo("BeginInvoke2 завершился"), null);

            PrintInfo($"Текущий статус завершения BeginInvoke2: {resAsync.IsCompleted}");

            var result = func.EndInvoke(resAsync);

            PrintInfo($"Получили результат EndInvoke2 в основном потоке: {result}");

            PrintInfo("Основной поток завершён");

            Console.ReadLine();
        }

        private static void PrintInfo(string str = null)
        {
            //Thread.Sleep(1000);
            Console.WriteLine($"Задача: {Task.CurrentId :D2}, Поток {Thread.CurrentThread.ManagedThreadId :D2}, {str}");
        }

        private static int PrintInfoInt(string str = null)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Задача: {Task.CurrentId:D2}, Поток {Thread.CurrentThread.ManagedThreadId:D2}, {str}");
            return Task.CurrentId ?? 0;
        }
    }
}
