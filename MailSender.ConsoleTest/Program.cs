using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace MailSender.ConsoleTest
{
    class Program
    {
        public delegate int BinaryOp(int x, int y);

        private static AutoResetEvent waitHandle = new AutoResetEvent(false);


        static void Main(string[] args)
        {
            #region Ex1

            //Console.WriteLine("Синхронный вызов метода: \n");
            //// Синхронный вызов метода
            //DelegateThread(1, 5000);

            //Console.WriteLine("\nАсинхронный вызов метода с двумя потоками: \n");
            //// Асинхронный вызов метода с применением делегата
            //BinaryOp bo = DelegateThread;

            #region Ex1.1

            //IAsyncResult ar = bo.BeginInvoke(1, 5000, null, null);

            //AsyncCallback cb;

            //WaitHandle waitHandle = ar.AsyncWaitHandle;

            //while (!waitHandle.WaitOne(50))
            //{
            //    // Выполнение операций в главном потоке
            //    Console.Write(".");
            //    //Thread.Sleep(50);
            //}
            //int result = bo.EndInvoke(ar);
            //Console.WriteLine("Result: " + result);

            #endregion


            #region Ex1.2

            ////bo.BeginInvoke(1, 5000, TakesAWhileCompleted, bo);
            //bo.BeginInvoke(1, 5000,
            //    ar => Console.WriteLine("Результат: " + ((ar.AsyncState as BinaryOp)?.EndInvoke(ar) ??
            //                            throw new ArgumentNullException("ar"))), bo); 
            //for (int i = 0; i < 200; i++)
            //{
            //    // Выполнение операций в главном потоке
            //    Console.Write(".");
            //    Thread.Sleep(50);
            //}

            #endregion

            #endregion

            #region Ex2

            //        Console.Title = "Информация о главном потоке программы";

            //        Thread thread = Thread.CurrentThread;
            //        thread.Name = "MyThread";
            //        thread.Priority = ThreadPriority.Highest;

            //        Console.WriteLine(@"    Имя домена приложения: {0}
            //ID контекста: {1}
            //Имя потока: {2}
            //Запущен ли поток? {3}
            //Приоритет потока: {4}
            //Состояние потока: {5}",
            //            Thread.GetDomain().FriendlyName, Thread.CurrentContext.ContextID, thread.Name, thread.IsAlive, thread.Priority, thread.ThreadState);


            #endregion

            #region Ex3

            //Console.Write("Сколько использовать потоков (1 или 2)?");
            //string number = Console.ReadLine();

            //Thread mythread = Thread.CurrentThread;
            //mythread.Name = "Первичный";

            //// Выводим информацию о потоке
            //Console.WriteLine("--> {0} главный поток", Thread.CurrentThread.Name);
            //MyThread mt = new MyThread();

            //switch (number)
            //{
            //    case "1":
            //        mt.ThreadNumbers();
            //        break;
            //    case "2":
            //        // Создаем поток
            //        Thread backgroundThread = new Thread(new ThreadStart(mt.ThreadNumbers));
            //        backgroundThread.Name = "Вторичный";
            //        //backgroundThread.IsBackground = true;
            //        backgroundThread.Start();
            //        break;
            //    default:
            //        Console.WriteLine("использую 1 поток");
            //        goto case "1";
            //}
            //MessageBox.Show("Сообщение ...", "Работа в другом потоке");

            #endregion

            #region Ex4

            //Console.WriteLine("Главный поток. ID: " + Thread.CurrentThread.ManagedThreadId);

            //Params pm = new Params(10, 10);
            //Thread t = new Thread(new ParameterizedThreadStart(Add));
            //t.IsBackground = true;
            //t.Start(pm);

            //// Задержка
            ////Thread.Sleep(5);

            //// Ждем уведомления
            ////
            //waitHandle.WaitOne();
            //Console.WriteLine("Все потоки завершились");
            ////Thread.CurrentThread.Join();


            #endregion

            #region Ex5

            //var state = new StateObject();
            //for (int i = 0; i < 1; i++)
            //    new Task(new SampleThread().RaceCondition, state).Start();

            #endregion

            TickTock tt = new TickTock();
            MyThread2 mt1 = new MyThread2("Tick", tt);
            MyThread2 mt2 = new MyThread2("Tock", tt);
            mt1.thrd.Join();
            mt2.thrd.Join();

            Console.WriteLine("Часы остановлены");

            Console.ReadLine();


        }

        static int DelegateThread(int data, int time)
        {
            Console.WriteLine("DelegateThread запущен");
            // Делаем задержку, для эмуляции длительной операции
            Thread.Sleep(time);
            Console.WriteLine("DelegateThread завершен");
            return ++data;
        }

        static void TakesAWhileCompleted(IAsyncResult ar)
        {
            if (ar == null) throw new ArgumentNullException("ar");

            BinaryOp bo = ar.AsyncState as BinaryOp;
            Trace.Assert(bo != null, "Неверный тип объекта");
            int result = bo.EndInvoke(ar);
            Console.WriteLine("Результат: " + result);
        }

        public class MyThread
        {
            public void ThreadNumbers()
            {
                // Информация о потоке
                Console.WriteLine("{0} поток использует метод ThreadNumbers", Thread.CurrentThread.Name);
                // Выводим числа
                Console.Write("Числа: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(i + ", ");
                    // Используем задержку
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
            }
        }

        static void Add(object obj)
        {
            if (obj is Params pr)
            {
                Console.WriteLine("ID потока метода Add(): " + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10000);
                Console.WriteLine("{0} + {1} = {2}", pr.a, pr.b, pr.a + pr.b);
            }

            // Сообщить другому потоку о завершении работы
            waitHandle.Set();
        }


    }

    public class Params
    {
        public int a, b;
        public Params(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }

    public class StateObject
    {
        private int state = 5;
        Object locker = new Object();

        public void ChangeState(int loop)
        {
            //lock (locker)
            //{
            //    if (state == 5)
            //    {
            //        state++;
            //        Trace.Assert(state == 6, "Состязание за ресурсы возникло после " + loop + " циклов");
            //    }

            //    state = 5;
            //}

            //if (state == 5)
            //{
            //    state++;
            //    Trace.Assert(state == 6, "Состязание за ресурсы возникло после " + loop + " циклов");
            //}

            //state = 5;

            int i = Interlocked.CompareExchange(ref state, 6, 5);
            Trace.Assert(state == 6, "Состязание за ресурсы возникло после " + loop + " циклов");
            state = 5;
            
        }
    }

    public class SampleThread
    {
        public void RaceCondition(object obj)
        {
            Trace.Assert(obj is StateObject, "obj должен иметь тип StateObject");
            StateObject state = obj as StateObject;
            int i = 0;
            while (true)
                state.ChangeState(i++);
        }
    }

    class TickTock
    {
        private object lockOn = new object();

        public void Tick(bool running)
        {
            lock (lockOn)
            {
                if (!running)
                {
                    // Остановить часы
                    Monitor.Pulse(lockOn);
                    return;
                }

                Console.Write("Тик ");
                // Разрешить выполнение метода Tock()
                Monitor.Pulse(lockOn);

                // Ожидать завершение Tock()
                Monitor.Wait(lockOn);
            }
        }

        public void Tock(bool running)
        {
            lock (lockOn)
            {
                if (!running)
                {
                    Monitor.Pulse(lockOn);
                    return;
                }

                Console.WriteLine("так");
                Monitor.Pulse(lockOn);
                Monitor.Wait(lockOn);
            }
        }
    }

    class MyThread2
    {
        public Thread thrd;
        TickTock ttobj;

        // Новый поток
        public MyThread2(string name, TickTock tt)
        {
            thrd = new Thread(this.Run);
            ttobj = tt;
            thrd.Name = name;
            thrd.Start();
        }

        void Run()
        {
            if (thrd.Name == "Tick")
            {
                for (int i = 0; i < 5; i++)
                    ttobj.Tick(true);
                ttobj.Tick(false);
            }
            else
            {
                for (int i = 0; i < 5; i++)
                    ttobj.Tock(true);
                ttobj.Tock(false);
            }
        }
    }
}
