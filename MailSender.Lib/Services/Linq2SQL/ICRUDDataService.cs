using System.Collections.Generic;
using MailSender.Lib.Data.LINQ2SQL;

namespace MailSender.Lib.Services.Linq2SQL
{
    public interface ICRUDDataService
    {
        IEnumerable<Recipient> GetAll();

        Recipient GetById(int id);

        void Create(Recipient item);

        void Update(Recipient item);

        void Delete(Recipient item);
    }
}