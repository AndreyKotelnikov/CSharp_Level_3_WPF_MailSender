using System.Collections.Generic;
using MailSender.Lib.Data;
using MailSender.Lib.Services.Interfaces;

namespace MailSender.Lib.Services.InMemory
{
    public class SendersDataServiceInMemory : DataServiceInMemory<Sender>, ISendersDataService
    {

        public SendersDataServiceInMemory()
        {
            List<Sender> testData = new List<Sender>
            {
                new Sender{Id = 1, Name = "Andrey", Adress = "Andrey@yandex.ru", Description = "Comment"},
                new Sender{Id = 2, Name = "Olga", Adress = "Olga@mail.ru" },
                new Sender{Id = 3, Name = "Maxim", Adress = "Maxim@gmail.com" }
            };
            _itemsList.AddRange(testData);
        }

    }
}