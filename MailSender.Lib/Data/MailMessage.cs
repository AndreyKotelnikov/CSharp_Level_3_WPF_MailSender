using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.Lib.Data.BasedEntities;

namespace MailSender.Lib.Data
{
    public class MailMessage : Entity
    {
        public string Subject { get; set; }

        public string Body { get; set; }
    }
}
