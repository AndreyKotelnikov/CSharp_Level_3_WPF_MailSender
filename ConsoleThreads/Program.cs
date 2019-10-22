using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleThreads
{
    class Program 
    {
        
        static void Main(string[] args)
        {
            //Logger logger = new Logger();
            //for (int i = 0; i < 5; i++)
            //{
            //    var thread = new Thread(logger.Print);
            //    thread.Start();
            //}

            //for (int i = 0; i < 50; i++)
            //{
            //    ThreadPool.QueueUserWorkItem(o => PrintForPool());
            //    Console.WriteLine($" ***{i}*** ");
            //    Thread.Sleep(10);
            //}

            var threads = new Thread[10];

            for (int i = 0; i < 10; i++)
            {
                var num = i; // Чтобы не было замыкания переменной
                threads[i] = new Thread(() => Console.WriteLine($"Сообщение {num}"));
            }

            for (int i = 0; i < 10; i++)
            {
                threads[i].Start();
            }

            

            Console.ReadLine();
        }

        //[MethodImpl(MethodImplOptions.Synchronized)]
        private static void Print()
        {
            Console.Write($"Поток {Thread.CurrentThread.ManagedThreadId} - ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i} ");
                Thread.Sleep(10);
            }
            Console.WriteLine("10");
        }

        private static void PrintForPool()
        {
            Console.WriteLine($"Количество ЦП: {Environment.ProcessorCount} и номер потока: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
        }
    }

    [Synchronization]
    internal class Logger : ContextBoundObject
    {
        public void Print()
        {
            Console.Write($"Поток {Thread.CurrentThread.ManagedThreadId} - ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i} ");
                Thread.Sleep(10);
            }
            Console.WriteLine("10");
        }
    }
}
