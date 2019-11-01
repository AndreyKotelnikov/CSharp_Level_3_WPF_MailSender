using System.Data.Entity;
using System.Data.Linq;
using MailSender.Lib.Data;
using MailSender.Lib.Services.Interfaces;

namespace MailSender.Lib.Services.Linq2SQL
{
    public class SchedulerTasksDataServiceEF : DataServiceEF<SchedulerTask, MailSender.Lib.EF.SchedulerTask>, ISchedulerTasksDataService
    {
        public SchedulerTasksDataServiceEF(DbContext dataContext) : base(dataContext)
        {

        }
    }
}