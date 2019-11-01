using System.Data.Entity;
using System.Data.Linq;
using MailSender.Lib.Data;
using MailSender.Lib.Services.Interfaces;

namespace MailSender.Lib.Services.Linq2SQL
{
    public class MailMessagesDataServiceEF : DataServiceEF<MailMessage, MailSender.Lib.EF.MailMessage>, IMailMessagesDataService
    {
        public MailMessagesDataServiceEF(DbContext dataContext) : base(dataContext)
        {

        }
    }
}