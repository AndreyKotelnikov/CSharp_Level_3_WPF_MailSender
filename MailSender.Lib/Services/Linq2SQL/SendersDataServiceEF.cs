using System.Data.Entity;
using System.Data.Linq;
using MailSender.Lib.Data;
using MailSender.Lib.Services.Interfaces;

namespace MailSender.Lib.Services.Linq2SQL
{
    public class SendersDataServiceEF : DataServiceEF<Sender, MailSender.Lib.EF.Sender>, ISendersDataService
    {
        public SendersDataServiceEF(DbContext dataContext) : base(dataContext)
        {

        }
    }
}