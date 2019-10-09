using MailSender.Lib.Data.LINQ2SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Lib.Services.Linq2SQL
{
    public class RecipientsDataServiceLinq2SQL : ICRUDDataService
    {
        private readonly MailSenderDBContext _db;

        public RecipientsDataServiceLinq2SQL(MailSenderDBContext db)
        {
            _db = db;
        }

        public void Create(Recipient item)
        {
            if (item.Id != 0) { return; }
            _db.Recipient.InsertOnSubmit(item);
            _db.SubmitChanges();
        }

        public void Delete(Recipient item)
        {
            _db.Recipient.DeleteOnSubmit(item);
            _db.SubmitChanges();
        }

        public IEnumerable<Recipient> GetAll() => _db.Recipient.ToArray();

        public Recipient GetById(int id) => _db.Recipient.FirstOrDefault(r => r.Id == id);

        public void Update(Recipient item)
        {
            _db.SubmitChanges();
        }
    }
}
