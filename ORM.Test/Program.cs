using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM.Test.Data;

using ORM.Test.Reporting;

namespace ORM.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //var list = Enumerable.Range(1, 10).ToList();
            //var del = list.FirstOrDefault();

            //string str = "gsjjk4hsAAf6";
            //var char1 = str[0];
            //string str2 = new string(str.Where(ch => char.IsDigit(ch) || char.IsUpper(ch)).ToArray());
            //Console.WriteLine($"{str2}");

            //using (ModelFirstDataContainer dbContainer = new ModelFirstDataContainer())
            //{
            //    dbContainer.Database.Log = s => Console.WriteLine($"{s}");
            //    dbContainer.SongMFSet.Add(new SongMF { Name = "Песня номер 5" });
            //    dbContainer.ArtistMFSet.Add(new ArtistMF() { Name = "Артист 3", SongMF = dbContainer.SongMFSet.Where(s => s.Id >= 3).ToList() });
            //    dbContainer.SaveChanges();
            //    Console.WriteLine($"{dbContainer.ArtistMFSet.FirstOrDefault(a => a.Id == 3)?.Name}");
            //}

            #region SQL запросы к базе

            //Opened connection at 30.10.2019 12:41:45 + 03:00
            //SELECT
            //    [Extent1].[Id] AS[Id],
            //    [Extent1].[Name] AS[Name],
            //    [Extent1].[Lenght] AS[Lenght],
            //    [Extent1].[Discription]
            //        AS[Discription]
            //FROM[dbo].[SongMFSet]
            //        AS[Extent1]
            //WHERE[Extent1].[Id] <= 3
            //-- Executing at 30.10.2019 12:41:45 +03:00
            //-- Completed in 10 ms with result: SqlDataReader
            //Closed connection at 30.10.2019 12:41:46 +03:00
            //Opened connection at 30.10.2019 12:41:46 +03:00
            //Started transaction at 30.10.2019 12:41:46 +03:00
            //INSERT[dbo].[ArtistMFSet]
            //        ([Name])
            //VALUES(@0)
            //SELECT[Id]
            //FROM[dbo].[ArtistMFSet]
            //        WHERE @@ROWCOUNT > 0 AND[Id] = scope_identity()
            //-- @0: 'Артист 2' (Type = String, Size = -1)
            //-- Executing at 30.10.2019 12:41:46 +03:00
            //-- Completed in 2 ms with result: SqlDataReader
            //INSERT[dbo].[SongArtist]
            //        ([Song_Id], [Artist_Id])
            //VALUES(@0, @1)
            //-- @0: '1' (Type = Int32)
            //-- @1: '2' (Type = Int32)
            //-- Executing at 30.10.2019 12:41:46 +03:00
            //-- Completed in 2 ms with result: 1
            //INSERT[dbo].[SongArtist]
            //        ([Song_Id], [Artist_Id])
            //VALUES(@0, @1)
            //-- @0: '2' (Type = Int32)
            //-- @1: '2' (Type = Int32)
            //-- Executing at 30.10.2019 12:41:46 +03:00
            //-- Completed in 0 ms with result: 1
            //INSERT[dbo].[SongArtist]
            //        ([Song_Id], [Artist_Id])
            //VALUES(@0, @1)
            //-- @0: '3' (Type = Int32)
            //-- @1: '2' (Type = Int32)
            //-- Executing at 30.10.2019 12:41:46 +03:00
            //-- Completed in 0 ms with result: 1
            //INSERT[dbo].[SongMFSet]
            //        ([Name], [Lenght], [Discription])
            //VALUES(@0, @1, NULL)
            //SELECT[Id]
            //FROM[dbo].[SongMFSet]
            //        WHERE @@ROWCOUNT > 0 AND[Id] = scope_identity()
            //-- @0: 'Песня номер 4' (Type = String, Size = -1)
            //-- @1: '1,5' (Type = Double)
            //-- Executing at 30.10.2019 12:41:46 +03:00
            //-- Completed in 1 ms with result: SqlDataReader
            //Committed transaction at 30.10.2019 12:41:46 +03:00
            //Closed connection at 30.10.2019 12:41:46 +03:00
            //Opened connection at 30.10.2019 12:41:46 +03:00
            //SELECT TOP(1)
            //    [Extent1].[Id] AS[Id],
            //    [Extent1].[Name]
            //        AS[Name]
            //FROM[dbo].[ArtistMFSet]
            //        AS[Extent1]
            //WHERE 2 = [Extent1].[Id]
            //-- Executing at 30.10.2019 12:41:46 +03:00
            //-- Completed in 0 ms with result: SqlDataReader
            //Closed connection at 30.10.2019 12:41:46 +03:00
            //Артист 2

            #endregion

            //using (CodeFirst codeFirst = new CodeFirst())
            //{
            //    codeFirst.Database.Log = Console.WriteLine;
            //    Console.WriteLine($@"{codeFirst.Songs.Count()} ");
            //}

            //var report = new Report();

            //report.CreatePackage("TestReport.docx");

            //Configuration configuration = new Configuration();
            //configuration.

            //Console.WriteLine((int)SomeEnum.Second);

            //int i = 1;
            //object obj = i;
            //++i;
            //Console.WriteLine(i);
            //Console.WriteLine(obj);
            //Console.WriteLine((short)obj);

            //ClassB object1 = new ClassA() as ClassB;
            //object1?.ClassMethod();
            //ClassB object2 = new ClassB();
            //object2.ClassMethod();
            //ClassA object3 = new ClassB();
            //object3.ClassMethod();

            //Console.WriteLine($"{Enumerable.Range(1, 11).Select(n => n + 30).ToArray()}");
            //Enumerable.Range(1, 10).Select(n =>
            //{
            //    Console.WriteLine($"{n + 30}");
            //    return n;
            //}).ToList();

            //System.Linq.Enumerable.Empty<int>();

            //Enumerable.Range(1, 10);

            //string[] cars = { "Nissan", "Aston Martin", "Chevrolet", "Alfa Romeo", "Chrysler", "Dodge", "BMW",
            //    "Ferrari", "Audi", "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};
            ////IEnumerable<string> items = cars.Where(p => p.StartsWith("A"));
            ////foreach (string s in items)
            ////    Console.WriteLine(s);

            //IEnumerable<string> items = cars.Where(s => Char.IsLower(s[4]));
            //Console.WriteLine("Здесь исключения нет, т.к. запрос еще не выполняется");

            //try
            //{
            //    foreach (string s in items)
            //        Console.WriteLine(s);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("\n" + ex.Message + ex.Source);
            //}

            string[] cars = { "Nissan", "Aston Martin", "Chevrolet", "Alfa Romeo", "Chrysler", "Dodge", "BMW",
                "Ferrari", "Audi", "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            //IEnumerable<int> sequence = cars.Select(p => p.Length);

            //foreach (int i in sequence)
            //    Console.Write(i + " ");

            //var sequence = cars.Select(p => new { p, p.Length }).ToList();

            //foreach (var i in sequence)
            //    Console.WriteLine("{0}{1}", i, System.Environment.NewLine);

            //try
            //{
            //    //foreach (Employee item in items)
            //    //    Console.WriteLine("{0} {1} {2}", item.id, item.firstName, item.lastName);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("{0}{1}", ex.Message, System.Environment.NewLine);
            //}

            //var nums = Enumerable.Repeat("ghfs", 10);

            //foreach (var i in nums)
            //    Console.Write(i + "  ");

            //Dictionary<string, Employee2> e2Dictionary =
            //    Employee2.GetEmployeesArray().ToDictionary(k => k.id, new MyStringifiedNumberComparer());

            //Employee2 e2 = e2Dictionary["2"];
            //Console.WriteLine("Сотрудником с id == \"2\" является " + e2.firstName + " " + e2.lastName);

            //e2 = e2Dictionary["00002"];
            //Console.WriteLine("Сотрудником с id == \"00002\" является " + e2.firstName + " " + e2.lastName);

            //EqualityComparer<int>.Default

            int agg = Enumerable
                .Range(1, 10)
                .Aggregate(0, (s, i) => s + i);
            Console.WriteLine("Сумма = " + agg);

            Console.ReadLine();
        }

        private enum SomeEnum
        {
            First = 4,
            Second,
            Third = 7
        }

    }

    public class MyStringifiedNumberComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return (Int32.Parse(x) == Int32.Parse(y));
        }

        public int GetHashCode(string obj)
        {
            return Int32.Parse(obj).ToString().GetHashCode();
        }
    }

    public class Employee2
    {
        public string id;
        public string firstName;
        public string lastName;

        public static ArrayList GetEmployeesArrayList()
        {
            ArrayList al = new ArrayList();

            al.Add(new Employee2 { id = "1", firstName = "Joe", lastName = "Rattz" });
            al.Add(new Employee2 { id = "2", firstName = "William", lastName = "Gates" });
            al.Add(new Employee2 { id = "3", firstName = "Anders", lastName = "Hejlsberg" });
            al.Add(new Employee2 { id = "4", firstName = "David", lastName = "Lightman" });
            al.Add(new Employee2 { id = "101", firstName = "Kevin", lastName = "Flynn" });
            return (al);
        }

        public static Employee2[] GetEmployeesArray()
        {
            return ((Employee2[])GetEmployeesArrayList().ToArray(typeof(Employee2)));
        }
    }

    public class ClassA
    {
        public virtual void ClassMethod()
        {
            Console.WriteLine("ClassA");
        }
    }

    public class ClassB : ClassA
    {
        public override void ClassMethod()
        {
            Console.WriteLine("ClassB");
        }
    }

    public class Common
    {
        public delegate bool IntFilter(int i);
        public static int[] FilterArrayOfInts(int[] ints, IntFilter filter)
        {
            ArrayList aList = new ArrayList();
            //aList.OfType<int>()
            foreach (int i in ints)
            {
                if (filter(i))
                {
                    aList.Add(i);
                }
            }
            return ((int[])aList.ToArray(typeof(int)));
        }
    }


}
