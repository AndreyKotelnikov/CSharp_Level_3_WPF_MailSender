using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using MailSender.Lib.Data;
using MailMessage = MailSender.Lib.Data.MailMessage;

namespace MailSender.Lib.Services.Interfaces
{
    public interface IMailSenderService
    {
        IMailSender CreateSender(Server server);
    }


    public interface IMailSender
    {
        void Send(MailMessage mailMessage, Sender from, Recipient to);

        void Send(MailMessage mailMessage, Sender from, IEnumerable<Recipient> to);
    }

    public class SmtpMailSenderService : IMailSenderService
    {
        public IMailSender CreateSender(Server server)
        {
            return new SmtpMailSender(
                server.Adress,
                server.Port,
                server.UseSSL,
                server.UserName,
                server.Password
                );
        }
    }

    public class SmtpMailSender : IMailSender
    {
        private readonly string _host;
        private readonly int _port;
        private readonly bool _useSsl;
        private readonly string _login;
        private readonly SecureString _password;

        public SmtpMailSender(string host, int port, bool useSSL, string login, SecureString password)
        {
            _host = host;
            _port = port;
            _useSsl = useSSL;
            _login = login;
            _password = password;
        }
        
        public void Send(MailMessage mailMessage, Sender from, Recipient to)
        {
            using (var server = new SmtpClient(_host, _port) { EnableSsl = _useSsl })
            {
                server.Credentials = new NetworkCredential(_login, _password);
                using (var msg = new System.Net.Mail.MailMessage())
                {
                    msg.From = new MailAddress(from.Adress, from.Name);
                    msg.To.Add(new MailAddress(to.Adress, to.Name));

                    server.Send(msg);
                }
            }
        }

        public void Send(MailMessage mailMessage, Sender from, IEnumerable<Recipient> to)
        {
            foreach (var recipient in to)
            {
                Send(mailMessage, from, recipient);
            }
        }
    }
}
