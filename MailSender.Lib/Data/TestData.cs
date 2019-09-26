using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Lib.Data
{
    public static class TestData
    {
        public static Server[] Servers { get; } = Enumerable.Range(0, 10)
            .Select(i => new Server {
                Name = $"Server_{i}",
                Adress = $"Server_{i}@server.ru",
                Port = 25,
                UserName = $"Server_{i}_user",
                Password = new System.Security.SecureString()
            })
            .ToArray();

        public static Sender[] Senders { get; } = Enumerable.Range(0, 10)
            .Select(i => new Sender
            {
                Name = $"Sender_{i}",
                Adress = $"Sender_{i}@Sender.ru",
            })
            .ToArray();

        public static MailMessage[] MailMessages { get; } = Enumerable.Range(0, 10)
            .Select(i => new MailMessage
            {
                Subject = $"Message_{i}",
                Body = $"Message_{i}_Body"
            })
            .ToArray();


    }
}
