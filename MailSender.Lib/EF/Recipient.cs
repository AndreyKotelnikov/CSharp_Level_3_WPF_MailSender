using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.Lib.Data.BasedEntities;

namespace MailSender.Lib.EF
{
    public class Recipient : Human
    {
        public virtual ICollection<RecipientsList> Lists { get; set; }
    }
}
