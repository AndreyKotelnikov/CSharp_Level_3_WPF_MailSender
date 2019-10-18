using MailSender.Lib.Data;
using MailSender.Lib.Services.Linq2SQL;
using System;
using System.Collections.Generic;
using MailSender.Lib.Additions;
using System.Text;
using System.Threading.Tasks;
using MailSender.Lib.Services.Interfaces;

namespace MailSender.Lib.Services.InMemory
{
    public class RecipientsDataServiceInMemory : DataServiceInMemory<Recipient>, IRecipientsDataService
    {

        public RecipientsDataServiceInMemory()
        {
            List<Recipient> testData = new List<Recipient>
            {
                new Recipient{Id = 1, Name = "Andrey", Adress = "Andrey@yandex.ru", Description = "Comment"},
                new Recipient{Id = 2, Name = "Olga", Adress = "Olga@mail.ru" },
                new Recipient{Id = 3, Name = "Maxim", Adress = "Maxim@gmail.com" }
            };
            _itemsList.AddRange(testData);
        }
        
    }
}
