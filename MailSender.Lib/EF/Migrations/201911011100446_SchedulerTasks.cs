namespace MailSender.Lib.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SchedulerTasks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SchedulerTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Name = c.String(nullable: false, maxLength: 120),
                        MailMessage_Id = c.Int(),
                        Recipients_Id = c.Int(),
                        Sender_Id = c.Int(),
                        Server_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MailMessages", t => t.MailMessage_Id)
                .ForeignKey("dbo.RecipientsLists", t => t.Recipients_Id)
                .ForeignKey("dbo.Senders", t => t.Sender_Id)
                .ForeignKey("dbo.Servers", t => t.Server_Id)
                .Index(t => t.MailMessage_Id)
                .Index(t => t.Recipients_Id)
                .Index(t => t.Sender_Id)
                .Index(t => t.Server_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SchedulerTasks", "Server_Id", "dbo.Servers");
            DropForeignKey("dbo.SchedulerTasks", "Sender_Id", "dbo.Senders");
            DropForeignKey("dbo.SchedulerTasks", "Recipients_Id", "dbo.RecipientsLists");
            DropForeignKey("dbo.SchedulerTasks", "MailMessage_Id", "dbo.MailMessages");
            DropIndex("dbo.SchedulerTasks", new[] { "Server_Id" });
            DropIndex("dbo.SchedulerTasks", new[] { "Sender_Id" });
            DropIndex("dbo.SchedulerTasks", new[] { "Recipients_Id" });
            DropIndex("dbo.SchedulerTasks", new[] { "MailMessage_Id" });
            DropTable("dbo.SchedulerTasks");
        }
    }
}
