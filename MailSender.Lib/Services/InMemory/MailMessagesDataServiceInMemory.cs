using System.Linq;
using MailSender.Lib.Data;
using MailSender.Lib.Services.Interfaces;

namespace MailSender.Lib.Services.InMemory
{
    public class MailMessagesDataServiceInMemory : DataServiceInMemory<MailMessage>, IMailMessagesDataService
    {

        public MailMessagesDataServiceInMemory()
        {
            _itemsList.AddRange(Enumerable.Range(1, 20)
                .Select(o => new MailMessage { Id = o, Subject = $"Message_{o}", Body = $"Body from Message_{o}" })
                .ToArray());
        }

    }
}