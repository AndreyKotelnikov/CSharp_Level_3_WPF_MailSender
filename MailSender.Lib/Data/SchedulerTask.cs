using MailSender.Lib.Data.BasedEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Lib.Data
{
    public class SchedulerTask : NamedEntity
    {
        public DateTime DateTime { get; set; }

        public virtual MailMessage MailMessage { get; set; }

        public virtual Sender Sender { get; set; }

        public virtual RecipientsList Recipients { get; set; }

        public virtual Server Server { get; set; }
    }
}
