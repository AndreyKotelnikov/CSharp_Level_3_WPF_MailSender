using System;
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

            var report = new Report();

            report.CreatePackage("TestReport.docx");

            Console.ReadLine();
        }
    }
}
