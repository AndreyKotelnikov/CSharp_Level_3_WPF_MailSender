using MailSender.Lib.Services.Linq2SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.Lib.Data.LINQ2SQL;

namespace ConsoleDataTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MailSenderDBContext dataContext = new MailSenderDBContext("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MailSender.db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            RecipientsDataServiceLinq2SQL recipients = new RecipientsDataServiceLinq2SQL(dataContext);
            var res = recipients.GetById(2);
        }
    }
}
