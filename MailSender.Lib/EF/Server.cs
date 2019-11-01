using System.Security;
using MailSender.Lib.Data.BasedEntities;

namespace MailSender.Lib.EF
{
    public class Server : NamedEntity
    {
        public string Adress { get; set; }

        public int Port { get; set; }

        public bool UseSSL { get; set; } = true;

        public string UserName { get; set; }

        public string Password { get; set; }

        public string SecretName { get; set; }
    }
}