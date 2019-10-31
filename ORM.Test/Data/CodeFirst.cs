using System.Runtime.CompilerServices;
using ORM.Test.Migrations;

namespace ORM.Test.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CodeFirst : DbContext
    {

        static CodeFirst()
        {
            System.Data.Entity.Database.SetInitializer(new MigrateDatabaseToLatestVersion<CodeFirst, Configuration>());
        }
        
        // Контекст настроен для использования строки подключения "CodFirst" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "ORM.Test.Data.CodFirst" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "CodFirst" 
        // в файле конфигурации приложения.
        public CodeFirst()
            : base("name=CodeFirst")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        //public DbSet<SongMF>

        public DbSet<Song> Songs { get; set; }

        public DbSet<Artist> Artists { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}