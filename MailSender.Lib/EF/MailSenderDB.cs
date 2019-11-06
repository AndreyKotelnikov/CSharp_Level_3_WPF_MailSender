using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.Lib.Data;
using MailSender.Lib.EF.Migrations;

namespace MailSender.Lib.EF
{
    public class MailSenderDB : DbContext
    {
        static MailSenderDB() => System.Data.Entity.Database.SetInitializer(new MigrateDatabaseToLatestVersion<MailSenderDB, Configuration>());

        public MailSenderDB() : base("Name=MailSenderDB") {}

        public MailSenderDB(string connectionString) : base(connectionString) { }

        public DbSet<Recipient> Recipients { get; set; }

        public DbSet<Sender> Senders { get; set; }

        public DbSet<Server> Servers { get; set; }

        public DbSet<MailMessage> MailMessages { get; set; }

        public DbSet<RecipientsList> Lists { get; set; }

        public DbSet<SchedulerTask> SchedulerTasks { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    // настройка полей с помощью Fluent API
        //    modelBuilder.Entity<Recipient>()
        //        .Property(c => c.Name).IsRequired().HasMaxLength(30);

        //    modelBuilder.Entity<Server>().Property(s => s.SecretName).IsRequired().HasColumnName("Сервер");

        //    DbQuery dbQuery = Set<Recipient>().

        //    //modelBuilder.Entity<Customer>()
        //    //    .Property(c => c.Photo).HasColumnType("image");

        //    //// вы можете настроить таблицу
        //    //modelBuilder.Entity<Customer>().ToTable("NewName_Customer");
        //}
    }
}
