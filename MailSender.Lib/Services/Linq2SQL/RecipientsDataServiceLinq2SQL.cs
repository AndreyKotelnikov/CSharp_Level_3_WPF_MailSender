using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MailSender.Lib.Additions;
using MailSender.Lib.Data.BasedEntities;
using MailSender.Lib.Data.LINQ2SQL;
using MailSender.Lib.Services.Interfaces;
using Recipient = MailSender.Lib.Data.Recipient;
using System.Data.Linq;

namespace MailSender.Lib.Services.Linq2SQL
{
    public class RecipientsDataServiceLinq2SQL : DataServiceLinq2SQL<Recipient, MailSender.Lib.Data.LINQ2SQL.Recipient>, IRecipientsDataService
    {
        public RecipientsDataServiceLinq2SQL(DataContext dataContext) : base(dataContext)
        {

        }
    }
    
}
