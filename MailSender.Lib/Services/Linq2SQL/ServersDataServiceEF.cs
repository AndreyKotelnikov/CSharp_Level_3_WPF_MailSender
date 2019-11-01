using System.Data.Entity;
using System.Data.Linq;
using MailSender.Lib.Data;
using MailSender.Lib.Services.Interfaces;

namespace MailSender.Lib.Services.Linq2SQL
{
    public class ServersDataServiceEF : DataServiceEF<Server, MailSender.Lib.EF.Server>, IServersDataService
    {
        public ServersDataServiceEF(DbContext dataContext) : base(dataContext)
        {

        }
    }
}