using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Lib.Data
{
    public class Server
    {
        public string Name { get; set; }

        public string Adress { get; set; }

        public int Port { get; set; }

        public bool UseSSL { get; set; } = true;

        public string UserName { get; set; }

        public SecureString Password { get; set; }
    }
}
