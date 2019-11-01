using System.Data.Entity;
using System.Data.Linq;
using MailSender.Lib.Data;
using MailSender.Lib.Services.Interfaces;

namespace MailSender.Lib.Services.Linq2SQL
{
    public class RecipientsListsDataServiceEF : DataServiceEF<RecipientsList, MailSender.Lib.EF.RecipientsList>, IRecipientsListsDataService
    {
        public RecipientsListsDataServiceEF(DbContext dataContext) : base(dataContext)
        {

        }
    }
}