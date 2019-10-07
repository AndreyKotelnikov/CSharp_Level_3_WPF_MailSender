using MailSender.Lib.Data.LINQ2SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Lib.Services.Linq2SQL
{
    public class RecipientsDataServiceLinq2SQL : IRecipientsDataService
    {
        private readonly MailSenderDBContext _db;

        public RecipientsDataServiceLinq2SQL(MailSenderDBContext db)
        {
            _db = db;
        }

        public IEnumerable<Recipient> GetAll() => _db.Recipient.ToArray();
    }
}
