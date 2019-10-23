using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Text;
using System.Threading;
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

        void ParallelSend(MailMessage mailMessage, Sender from, IEnumerable<Recipient> to);

        Task SendAsync(MailMessage mailMessage, Sender from, Recipient to);

        Task SendAsync(MailMessage mailMessage, Sender from, IEnumerable<Recipient> to, IProgress<double> progress = null, CancellationToken cancellationToken = default);
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
            using var server = new SmtpClient(_host, _port)
            {
                EnableSsl = _useSsl, Credentials = new NetworkCredential(_login, _password)
            };
            using var msg = new System.Net.Mail.MailMessage {From = new MailAddress(@from.Adress, @from.Name)};
            msg.To.Add(new MailAddress(to.Adress, to.Name));

            server.Send(msg);
        }

        public void Send(MailMessage mailMessage, Sender from, IEnumerable<Recipient> to)
        {
            foreach (var recipient in to)
            {
                Send(mailMessage, from, recipient);
            }
        }

        public void ParallelSend(MailMessage mailMessage, Sender from, IEnumerable<Recipient> to)
        {
            //foreach (var recipient in to)
            //{
            //    var currentRecipient = recipient;
            //    new Thread(() => Send(mailMessage, from, currentRecipient))
            //    {
            //        Name = $"Поток отправки почты от {from.Adress} к {recipient.Adress}",
            //        Priority = ThreadPriority.BelowNormal,
            //        IsBackground = true
            //    }
            //        .Start();
            //}

            foreach (Recipient recipient in to)
            {
                var currentRecipient = recipient;
                ThreadPool.QueueUserWorkItem(p => Send(mailMessage, from, currentRecipient));
            }
        }

        public async Task SendAsync(MailMessage mailMessage, Sender from, Recipient to)
        {
            using var server = new SmtpClient(_host, _port)
            {
                EnableSsl = _useSsl,
                Credentials = new NetworkCredential(_login, _password)
            };
            using var msg = new System.Net.Mail.MailMessage { From = new MailAddress(@from.Adress, @from.Name) };
            msg.To.Add(new MailAddress(to.Adress, to.Name));

            await server.SendMailAsync(msg);
        }

        public async Task SendAsync(MailMessage mailMessage, 
            Sender from, 
            IEnumerable<Recipient> to, 
            IProgress<double> progress = null, 
            CancellationToken cancellationToken = default
            )
        {
            Recipient[] recipients = to.ToArray();

            for (int i = 0; i < recipients.Length; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await SendAsync(mailMessage, from, recipients[1]);
                progress?.Report((double)(i + 1) / recipients.Length);
            }

            progress?.Report(1);
        }
    }
}
