using MailSender.Lib.Services.Linq2SQL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.Lib.Data.LINQ2SQL;
using MailSender.Lib.EF;
using MailSender.Lib.EF.Migrations;

namespace ConsoleDataTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //MailSenderDBContext dataContext = new MailSenderDBContext("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MailSender.db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            //RecipientsDataServiceEf recipients = new RecipientsDataServiceEf(dataContext);
            //var res = recipients.GetById(2);

            Configuration configuration = new Configuration();
            configuration.SeedDebug(new MailSenderDB());

            Console.ReadLine();
        }
    }
}
