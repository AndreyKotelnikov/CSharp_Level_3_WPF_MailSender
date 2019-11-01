using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    }
}
