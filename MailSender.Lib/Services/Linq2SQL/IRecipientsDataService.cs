using System.Collections.Generic;
using MailSender.Lib.Data.LINQ2SQL;

namespace MailSender.Lib.Services.Linq2SQL
{
    public interface IRecipientsDataService
    {
        IEnumerable<Recipient> GetAll();

        void Create(Recipient item);

        void Update(Recipient item);

        void Delete(Recipient item);
    }
}