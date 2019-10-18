using System.Collections.Generic;
using MailSender.Lib.Data;
using MailSender.Lib.Services.Interfaces;

namespace MailSender.Lib.Services.InMemory
{
    public class ServersDataServiceInMemory : DataServiceInMemory<Server>, IServersDataService
    {

        public ServersDataServiceInMemory()
        {
            List<Server> testData = new List<Server>
            {
                new Server{Id = 1, Name = "Yandex", Adress = "Yandex.ru", UseSSL = true},
                new Server{Id = 2, Name = "Mail", Adress = "Mail.ru" , UseSSL = true},
                new Server{Id = 3, Name = "Google", Adress = "Gmail.com" , UseSSL = true}
            };
            _itemsList.AddRange(testData);
        }

    }
}