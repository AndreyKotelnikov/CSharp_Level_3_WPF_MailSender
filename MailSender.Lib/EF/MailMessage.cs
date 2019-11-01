using MailSender.Lib.Data.BasedEntities;

namespace MailSender.Lib.EF
{
    public class MailMessage : Entity
    {
        public string Subject { get; set; }

        public string Body { get; set; }
    }
}