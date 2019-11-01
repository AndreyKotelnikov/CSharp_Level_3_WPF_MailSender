using System.Collections.Generic;

namespace MailSender.Lib.EF.Migrations
{
    //using ORM.Test.Reporting;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security;

    public sealed class Configuration : DbMigrationsConfiguration<MailSender.Lib.EF.MailSenderDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"EF\Migrations";
        }

        public void SeedDebug(MailSender.Lib.EF.MailSenderDB context) => Seed(context);

        protected override void Seed(MailSender.Lib.EF.MailSenderDB context)
        {
            try
            {
                if (!context.Recipients.Any())
                {
                    var recipientss = new Recipient[10];
                    for (var i = 0; i < recipientss.Length; i++)
                    {
                        recipientss[i] = new Recipient
                        {
                            Name = $"Получатель {i + 1}",
                            Adress = $"server_{i + 1}@mail.ru",
                            Description = i % 3 == 0 ? $"Комментарий {i + 1}" : null
                        };
                    }

                    context.Recipients.AddRange(recipientss);
                    context.SaveChanges();
                }

                if (!context.Senders.Any())
                {
                    Sender[] senders = new Sender[10];
                    for (var i = 0; i < senders.Length; i++)
                    {
                        senders[i] = new Sender
                        {
                            Name = $"Отправитель {i + 1}",
                            Adress = $"server_{i + 1}@mail.ru",
                            Description = i % 3 == 0 ? $"Комментарий {i + 1}" : null
                        };
                    }

                    context.Senders.AddRange(senders);
                    context.SaveChanges();
                }

                if (!context.Servers.Any())
                {
                    var servers = new Server[10];
                    for (var i = 0; i < servers.Length; i++)
                    {
                        servers[i] = new Server
                        {
                            Name = $"Сервер {i + 1}",
                            Adress = $"Адрес_{i + 1}",
                            Port = i * 10,
                            UseSSL = true,
                            UserName = $"Пользователь {i + 1}",
                            Password = null
                        };
                    }

                    context.Servers.AddRange(servers);
                    context.SaveChanges();
                }

                if (!context.MailMessages.Any())
                {
                    var mailMessages = new MailMessage[10];
                    for (var i = 0; i < mailMessages.Length; i++)
                    {
                        mailMessages[i] = new MailMessage
                        {
                            Subject = $"Тема_{i + 1}",
                            Body = $"Тело письма {i + 1}"
                        };
                    }

                    context.MailMessages.AddRange(mailMessages);
                    context.SaveChanges();
                }

                if (!context.Lists.Any())
                {
                    var recipientsLists = new RecipientsList[2];
                    for (var i = 0; i < recipientsLists.Length; i++)
                    {
                        recipientsLists[i] = new RecipientsList
                        {
                            Name = $"Лист {i + 1}",
                            Recipients = new List<Recipient>()
                        };

                        foreach (var recipient in context.Recipients.Where(r => r.Id <= (2 + (i * 2))).ToArray())
                        {
                            recipientsLists[i].Recipients.Add(recipient);
                        }
                    }

                    context.Lists.AddRange(recipientsLists);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                //var report = new Report
                //{
                //    DataValue = e.InnerException?.Message ?? e.Message
                //};
                //report.CreatePackage("UpdateReport.docx");
                throw;
            }
        }
    }
}
