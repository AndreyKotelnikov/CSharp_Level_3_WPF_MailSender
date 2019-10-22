using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace ParallelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 151;
            Console.WriteLine($"Вычисляем факториал числа {number} обычной рекурсией");
            Stopwatch watch = Stopwatch.StartNew();
            watch.Start();
            double result = FactorialRecurcion(number);
            watch.Stop();
            Console.WriteLine($"Результат = {result}, время затрачено: {watch.ElapsedMilliseconds}");

            Console.WriteLine($"Вычисляем факториал числа {number} параллельно");
            watch.Restart();
            result = FactorialParallel(number);
            watch.Stop();
            Console.WriteLine($"Результат = {result}, время затрачено: {watch.ElapsedMilliseconds}");

            Console.ReadLine();

        }

        private static double FactorialRecurcion(double number, double limit = 1)
        {
            if (Math.Abs(number - limit) <= double.Epsilon || number < 0)
            {
                return 1;
            }

            return number * FactorialRecurcion(--number, limit);
        }

        private static double FactorialParallel(double number)
        {
            //ThreadPool.GetMaxThreads(out int workerThreads, out int completionPortThreads);
            int workerThreads = Environment.ProcessorCount;
            double delta = Math.Floor(number / workerThreads) >= 1
                ? Math.Floor(number / workerThreads)
                : 1;
            int remainderOfDivision = Convert.ToInt32(number) % workerThreads;

            int numberOfItems = workerThreads > number
                ? Convert.ToInt32(number)
                : remainderOfDivision == 0
                    ? workerThreads
                    : workerThreads + 1;

            numberOfItems = Math.Abs(numberOfItems);

            double[] stateArray = new double[numberOfItems];

            Semaphore semaphore = new Semaphore(0, numberOfItems + 1);

            for (int i = 0; i < numberOfItems; i++)
            {
                int currentI = i;
                double startNumber;
                if (remainderOfDivision != 0 && workerThreads < number && i == numberOfItems - 1)
                {
                    startNumber = delta* currentI + remainderOfDivision;
                }
                else
                {
                    startNumber = delta * (currentI + 1);
                }
                ThreadPool.QueueUserWorkItem(p => Factorial(startNumber, delta * currentI, semaphore, out stateArray[currentI]));
            }

            //Thread.Sleep(2000);

            while (stateArray.Any(o => o < Double.Epsilon))
            {
                Console.Write(".");
            }
            Console.WriteLine();

            double result = stateArray.Length > 0 
                ? 1 
                : 0;

            foreach (var item in stateArray)
            {
                result *= item;
            }

            return result;

        }

        private static void Factorial(double number, double limit, Semaphore semaphore, out double result)
        {
            //semaphore.WaitOne();
            double res = 1;

            for (double i = number; i > limit; i--)
            {
                res *= i;
            }

            result = res;
            //semaphore.Release();
        }
    }
}
