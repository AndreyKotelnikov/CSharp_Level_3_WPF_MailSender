using System.Collections.Generic;
using MailSender.Lib.Data.LINQ2SQL;

namespace MailSender.Lib.Services.Linq2SQL
{
    public interface IRecipientsDataService
    {
        IEnumerable<Recipient> GetAll();
    }
}