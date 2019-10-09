using MailSender.Lib.Data.LINQ2SQL;
using MailSender.Lib.Services.Linq2SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using MailSender.Lib.Additions;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Lib.Services.InMemory
{
    public class RecipientsDataServiceInMemory : ICRUDDataService
    {

        private readonly List<Recipient> _recipients = new List<Recipient>
        {
            new Recipient{Id = 1, Name = "Andrey", Adress = "Andrey@yandex.ru", Description = "Comment"},
            new Recipient{Id = 2, Name = "Olga", Adress = "Olga@mail.ru" },
            new Recipient{Id = 3, Name = "Maxim", Adress = "Maxim@gmail.com" }
        };

        public void Create(Recipient item)
        {
            if (item.Id != 0) { return; }
            item.Id = _recipients.Count == 0 ? 1 : _recipients.Max(r => r.Id) + 1;
            Recipient newRecipientInList = new Recipient();
            item.CloneTo(ref newRecipientInList);
            _recipients.Add(newRecipientInList);
        }

        public void Delete(Recipient item)
        {
            _recipients.Remove(_recipients.FirstOrDefault(r => r.Id == item.Id));
        }

        public IEnumerable<Recipient> GetAll() => (_recipients as IEnumerable<Recipient>).ToArray();


        public Recipient GetById(int id) => _recipients.FirstOrDefault(r => r.Id == id).Copy();

        public void Update(Recipient item)
        {
            if (!_recipients.Select(r => r.Id).Contains(item.Id)) { return; }
            Recipient recipientInList = _recipients.FirstOrDefault(r => r.Id == item.Id);
            item.CloneTo(ref recipientInList);
        }

        
    }
}
