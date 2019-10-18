using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using ThreadState = System.Threading.ThreadState;

namespace MailSender.ConsoleTest
{
    class Program
    {

        public delegate int BinaryOp(int x, int y);

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

            #region Ex6

            //TickTock tt = new TickTock();
            //MyThread2 mt1 = new MyThread2("Tick", tt);
            //MyThread2 mt2 = new MyThread2("Tock", tt);
            //mt1.thrd.Join();
            //mt2.thrd.Join();

            //Console.WriteLine("Часы остановлены");
            #endregion

            #region Ex7

            //IncThread mt1 = new IncThread("Inc thread", 5);
            //Console.WriteLine("Создал поток 1");
            //// разрешить инкременирующему потоку начаться
            ////Thread.Sleep(1);

            //DecThread mt2 = new DecThread("Dec thread", 5);
            //Console.WriteLine("Создал поток 2");

            //Console.WriteLine("Жду другие потоки");
            //mt1.Thrd.Join();
            //mt2.Thrd.Join();

            #endregion

            #region Ex8

            //ManualResetEvent evtObj = new ManualResetEvent(false);

            //MyThread2 mt1 = new MyThread2("Событийный поток 1", evtObj);

            //Console.WriteLine("Основной поток ожидает событие");

            //evtObj.WaitOne();

            //Console.WriteLine("Основной поток получил уведомление о событии от первого потока");

            //evtObj.Reset();

            //mt1 = new MyThread2("Событийный поток 2", evtObj);

            //evtObj.WaitOne();

            //Console.WriteLine("Основной поток получил уведомление о событии от второго потока");

            #endregion

            #region Ex9

            //const int numberTasks = 2;
            //const int partitionSize = 1000000;
            //var data = new List<string>(FillData(partitionSize * numberTasks));

            //var barrier = new Barrier(numberTasks + 1);

            //var taskFactory = new TaskFactory();
            //var tasks = new Task<int[]>[numberTasks];
            //for (int i = 0; i < numberTasks; i++)
            //{
            //    tasks[i] = taskFactory.StartNew<int[]>(CalculationInTask,
            //        Tuple.Create(i, partitionSize, barrier, data));
            //}
            //barrier.SignalAndWait();

            //var resultCollection = tasks[0].Result.Zip(tasks[1].Result, (c1, c2) => c1 + c2);

            //char ch = 'a';
            //int sum = 0;

            #endregion

            #region Ex10

            //try
            //{
            //    MyThread3 mt1 = new MyThread3("Мой поток");
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Прерывание потока");

            //    mt1.Thrd.Abort();

            //    // Ожидание прерывания
            //    mt1.Thrd.Join();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message + " " + ((e as ThreadAbortException)?.ExceptionState as Thread)?.ThreadState);

            //}

            //Console.WriteLine("Основной поток прерван");
            #endregion

            #region Ex11

            //// Делегат для типа Timer
            //TimerCallback timeCB = new TimerCallback(PrintTime);

            //Timer time = new Timer(timeCB, null, 0, 1000);

            #endregion

            #region Ex12

            //int nWorkerThreads;
            //int nCompletionThreads;
            //ThreadPool.GetMaxThreads(out nWorkerThreads, out nCompletionThreads);
            //Console.WriteLine("Максимальное количество потоков: " + nWorkerThreads
            //                                                      + "\nПотоков ввода-вывода доступно: " + nCompletionThreads);
            //for (int i = 0; i < 5; i++)
            //    ThreadPool.QueueUserWorkItem(JobForAThread);
            //Thread.Sleep(3000);

            #endregion

            #region Ex13

            //Console.WriteLine("Основной поток запущен");

            //Task task = new Task(MyTask1);

            //// Запустить задачу
            //task.Start();

            //for (int i = 0; i < 60; i++)
            //{
            //    Console.Write(".");
            //    Thread.Sleep(100);
            //}

            //Console.WriteLine("Основной поток завершен");

            #endregion

            #region Ex14

            //Console.WriteLine("Основной поток запущен");

            //Task task1 = new Task(MyTask2);
            //Task task2 = new Task(MyTask2);

            //// Запустить задачу
            //task1.Start();
            //task2.Start();

            ////for (int i = 0; i < 60; i++)
            ////{
            ////    Console.Write(".");
            ////    Thread.Sleep(100);
            ////}

            //Task.WaitAll(task1, task2);
            //TaskFactory factory = Task.Factory;

            //Console.WriteLine("Основной поток завершен");

            #endregion

            #region Ex15

            //Console.WriteLine("Основной поток запущен");

            //// Используем лямбда-выражение
            //Task task1 = Task.Factory.StartNew(() => {
            //    Console.WriteLine("MyTask3() №{0} запущен", Task.CurrentId);

            //    for (int count = 0; count < 10; count++)
            //    {
            //        Thread.Sleep(500);
            //        Console.WriteLine("В методе MyTask3 №{0} подсчет равен {1}", Task.CurrentId, count);
            //    }

            //    Console.WriteLine("MyTask3() #{0} завершен", Task.CurrentId);
            //});


            //task1.Wait();
            //task1.Dispose();
            //CancellationToken ct = new CancellationToken();
            //CancellationTokenSource cts = new CancellationTokenSource();



            //Console.WriteLine("Основной поток завершен");

            #endregion

            #region Ex16

            //Console.WriteLine("Основной поток запущен");

            //// Объект источника признаков отмены
            //CancellationTokenSource cancelTokSSrc = new CancellationTokenSource();

            //// Запустить задачу, передав ей признак отмены
            //Task tsk = Task.Factory.StartNew(MyTask3, cancelTokSSrc.Token, cancelTokSSrc.Token);

            //Thread.Sleep(2000);
            //try
            //{
            //    // отменить задачу
            //    cancelTokSSrc.Cancel();
            //    tsk.Wait();
            //}
            //catch (AggregateException exc)
            //{
            //    if (tsk.IsCanceled)
            //        Console.WriteLine("Задача tsk отменена");
            //}
            //finally
            //{
            //    tsk.Dispose();
            //    cancelTokSSrc.Dispose();
            //}

            //Console.WriteLine("Основной поток завершен");

            #endregion

            #region Ex17

            //Console.WriteLine("Основной поток запущен");

            //// Выполнить параллельно оба именованных метода
            //Parallel.Invoke(MyMeth, MyMeth2);
            

            //Console.WriteLine("Основной поток завершен");

            #endregion

            #region Ex18

            //Console.WriteLine("Основной поток запущен");

            //data = new int[100000000];

            //DateTime start = DateTime.Now;

            //for (int i = 0; i < data.Length; i++)
            //    data[i] = i;

            //DateTime end = DateTime.Now;

            //Console.WriteLine($"Создание последовательно: {(end - start).TotalSeconds}");


            //start = DateTime.Now;

            //for (int i = 0; i < data.Length; i++)
            //{
            //    MyTransform(i);
            //}

            //end = DateTime.Now;

            //Console.WriteLine($"Последовательно: {(end - start).TotalSeconds}");

            //data = new int[100000000];

            //start = DateTime.Now;

            //// Распараллелить цикл методом For()
            //Parallel.For(0, data.Length, (i) => data[i] = i);

            //end = DateTime.Now;

            //Console.WriteLine($"Создание параллельно: {(end - start).TotalSeconds}");

            //start = DateTime.Now;

            //// Распараллелить цикл методом For()
            //Parallel.For(0, data.Length, MyTransform);

            //end = DateTime.Now;

            //Console.WriteLine($"Параллельно: {(end - start).TotalSeconds}");

            //Console.WriteLine("Основной поток завершен");

            #endregion

            #region Ex19

            //Console.WriteLine("Основной поток запущен");

            //// Время выполнения цикла
            //Stopwatch sw = new Stopwatch();

            //data = new int[100000000];

            //sw.Start();

            //// Параллельный вариант инициализации массива в цикле
            //Parallel.For(0, data.Length, (i) => data[i] = i);

            //sw.Stop();
            //Console.WriteLine("|| исполнение цикла: {0} секунд", sw.Elapsed.TotalSeconds);
            //sw.Reset();

            //sw.Start();
            //for (int i = 0; i < data.Length; i++)
            //    data[i] = i;
            //sw.Stop();
            //Console.WriteLine("Последовательное исполнение цикла: {0} секунд", sw.Elapsed.TotalSeconds);
            //sw.Reset();
            //Console.WriteLine();

            //sw.Start();
            //// Распараллелить цикл методом For()
            //Parallel.For(0, data.Length, MyTransform);
            //sw.Stop();
            //Console.WriteLine("|| преобразование данных в цикле: {0} секунд",
            //    sw.Elapsed.TotalSeconds);
            //sw.Reset();

            //sw.Start();
            //for (int i = 0; i < data.Length; i++)
            //    MyTransform(i);
            //sw.Stop();
            //Console.WriteLine("Последовательное преобразование данных в цикле: {0} секунд",
            //    sw.Elapsed.TotalSeconds);

            //Console.WriteLine("Основной поток завершен");

            #endregion



            Console.ReadLine();


        }

        static int[] data = null;

        static void MyTransform(int i)
        {
            data[i] = data[i] / 10;

            if (data[i] < 10000) data[i] = 0;
            if (data[i] >= 10000) data[i] = 100;
            if (data[i] > 20000) data[i] = 200;
            if (data[i] > 30000) data[i] = 300;
        }


        /// Методы, исполняемые как задача
        static void MyMeth()
        {
            Console.WriteLine("MyMeth запущен");
            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("--> MyMeth Count=" + count);
            }
            Console.WriteLine("MyMeth завершен");
        }

        static void MyMeth2()
        {
            Console.WriteLine("MyMeth2 запущен");
            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("--> MyMeth2 Count=" + count);
            }
            Console.WriteLine("MyMeth2 завершен");
        }

        static void MyTask3(Object ct)
        {
            CancellationToken cancelTok = (CancellationToken)ct;
            cancelTok.ThrowIfCancellationRequested();

            Console.WriteLine("MyTask3() №{0} запущен", Task.CurrentId);

            for (int count = 0; count < 10; count++)
            {
                // Используем опрос
                if (!cancelTok.IsCancellationRequested)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("В методе MyTask3 №{0} подсчет равен {1}", Task.CurrentId, count);
                }
                else
                {
                    cancelTok.ThrowIfCancellationRequested();
                }
            }

            Console.WriteLine("MyTask3() #{0} завершен", Task.CurrentId);
        }

        private static AutoResetEvent waitHandle = new AutoResetEvent(false);

        // Метод выполняемый в качестве задачи
        static void MyTask2()
        {
            Console.WriteLine("MyTask2() №{0} запущен", Task.CurrentId);

            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В методе MyTask2 №{0} подсчет равен {1}", Task.CurrentId, count);
            }
        }

        // Метод выполняемый в качестве задачи
        static void MyTask1()
        {
            Console.WriteLine("MyTask1() запущен");

            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В методе MyTask1 подсчет равен " + count);
            }
        }


        static void JobForAThread(object state)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("цикл {0}, выполнение внутри потока из пула {1}",
                    i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(50);
            }
        }


        static void PrintTime(object state)
        {
            Console.Clear();
            Console.WriteLine("Текущее время:  " +
                              DateTime.Now.ToLongTimeString());
            Console.WriteLine("\nНажми чтоб выйти");
        }

        class MyThread3
        {
            
            public Thread Thrd;

            public MyThread3(string name)
            {
                Thrd = new Thread(this.Run);
                Thrd.Name = name;
                Thrd.Start();
            }

            // Точка входа в поток
            void Run()
            {
                Console.WriteLine(Thrd.Name + " начат");
                try
                {
                    for (int i = 1; i <= 1000; i++)
                    {
                        Console.Write(i + " ");
                        if ((i % 10) == 0)
                        {
                            Console.WriteLine();
                            Thread.Sleep(250);
                        }
                    }
                }
                catch (ThreadAbortException exc)
                {
                    //Thread.ResetAbort();
                    if ((int)exc.ExceptionState == 0)
                    {
                        Console.WriteLine("Прерывание отменено! Код завершения: "
                                          + exc.ExceptionState);
                        Thread.ResetAbort();
                    }
                    else
                        Console.WriteLine("Поток прерван, код завершения "
                                          + exc.ExceptionState);
                }
                Console.WriteLine(Thrd.Name + " завершен");
            }
        }



        public static IEnumerable<string> FillData(int size)
        {
            List<string> data = new List<string>(size);
            Random r = new Random();
            for (int i = 0; i < size; i++)
                data.Add(GetString(r));
            return data;
        }

        private static string GetString(Random r)
        {
            StringBuilder sb = new StringBuilder(6);
            for (int i = 0; i < 6; i++)
                sb.Append((char)(r.Next(26) + 97));
            return sb.ToString();
        }

        static int[] CalculationInTask(object p)
        {
            var p1 = p as Tuple<int, int, Barrier, List<string>>;
            Barrier barrier = p1.Item3;
            
            List<string> data = p1.Item4;

            int start = p1.Item1 * p1.Item2;
            int end = start + p1.Item2;

            Console.WriteLine("Задача {0}: раздел от {1} до {2}",
                Task.CurrentId, start, end);

            int[] charCount = new int[26];
            for (int j = start; j < end; j++)
            {
                char c = data[j][0];
                charCount[c - 97]++;
            }

            Console.WriteLine("Задача {0} завершила вычисление. {1} раз а, {2} раз z",
                Task.CurrentId, charCount[0], charCount[25]);
            barrier.RemoveParticipant();
            Console.WriteLine("Задача {0} удалена; количество оставшихся участников: {1}",
                Task.CurrentId, barrier.ParticipantsRemaining);
            return charCount;
        }


        class MyThread2
        {
            public Thread Thrd;
            ManualResetEvent mre;

            public MyThread2(string name, ManualResetEvent evt)
            {
                Thrd = new Thread(this.Run);
                Thrd.Name = name;
                mre = evt;
                Thrd.Start();
            }

            void Run()
            {
                Console.WriteLine("Внутри потока " + Thrd.Name);

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(Thrd.Name);
                    Thread.Sleep(500);
                }

                Console.WriteLine(Thrd.Name + " завершен!");

                // Уведомление о событии
                mre.Set();
            }
        }

        // В этом классе содержится общий ресурс в виде переменной Count,
        // а так же мьютекс mtx
        class SharedRes
        {
            public static int Count;
            public static Mutex mtx = new Mutex();
        }

        // В этом классе Count инкрементируется
        class IncThread
        {
            int num;
            public Thread Thrd;

            public IncThread(string name, int n)
            {
                Thrd = new Thread(this.Run);
                num = n;
                Thrd.Name = name;
                Thrd.Start();
            }

            // Точка входа в поток
            void Run()
            {
                Console.WriteLine(Thrd.Name + " ожидает мьютекс");

                // Получить мьютекс
                //SharedRes.mtx.WaitOne();

                Console.WriteLine(Thrd.Name + " получает мьютекс");

                do
                {
                    // Получить мьютекс
                    SharedRes.mtx.WaitOne();
                    Thread.Sleep(500);
                    SharedRes.Count++;
                    Console.WriteLine("в потоке {0}, Count={1}", Thrd.Name, SharedRes.Count);
                    SharedRes.mtx.ReleaseMutex();
                    num--;
                } while (num > 0);

                Console.WriteLine(Thrd.Name + " освобождает мьютекс");

                //SharedRes.mtx.ReleaseMutex();

            }
        }

        class DecThread
        {
            int num;
            public Thread Thrd;

            public DecThread(string name, int n)
            {
                Thrd = new Thread(new ThreadStart(this.Run));
                num = n;
                Thrd.Name = name;
                Thrd.Start();
            }

            // Точка входа в поток
            void Run()
            {
                Console.WriteLine(Thrd.Name + " ожидает мьютекс");

                // Получить мьютекс
                //SharedRes.mtx.WaitOne();

                Console.WriteLine(Thrd.Name + " получает мьютекс");

                do
                {
                    SharedRes.mtx.WaitOne();
                    Thread.Sleep(500);
                    SharedRes.Count--;
                    Console.WriteLine("в потоке {0}, Count={1}", Thrd.Name, SharedRes.Count);
                    SharedRes.mtx.ReleaseMutex();
                    num--;
                } while (num > 0);

                Console.WriteLine(Thrd.Name + " освобождает мьютекс");

                //SharedRes.mtx.ReleaseMutex();
            }
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
