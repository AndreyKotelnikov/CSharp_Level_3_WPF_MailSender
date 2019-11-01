using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.Lib.Data;
using MailSender.Lib.Services.Interfaces;

namespace MailSender.Lib.Services.Linq2SQL
{
    public class RecipientsDataServiceEF : DataServiceEF<Recipient, MailSender.Lib.EF.Recipient>, IRecipientsDataService
    {
        public RecipientsDataServiceEF(DbContext dataContext) : base(dataContext)
        {

        }
    }
}
