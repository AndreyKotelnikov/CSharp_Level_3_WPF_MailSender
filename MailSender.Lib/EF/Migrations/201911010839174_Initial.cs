namespace MailSender.Lib.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RecipientsLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 120),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Recipients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adress = c.String(),
                        Description = c.String(),
                        Name = c.String(nullable: false, maxLength: 120),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MailMessages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subject = c.String(),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Senders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adress = c.String(),
                        Description = c.String(),
                        Name = c.String(nullable: false, maxLength: 120),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Servers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adress = c.String(),
                        Port = c.Int(nullable: false),
                        UseSSL = c.Boolean(nullable: false),
                        UserName = c.String(),
                        SecretName = c.String(),
                        Name = c.String(nullable: false, maxLength: 120),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RecipientRecipientsLists",
                c => new
                    {
                        Recipient_Id = c.Int(nullable: false),
                        RecipientsList_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Recipient_Id, t.RecipientsList_Id })
                .ForeignKey("dbo.Recipients", t => t.Recipient_Id, cascadeDelete: true)
                .ForeignKey("dbo.RecipientsLists", t => t.RecipientsList_Id, cascadeDelete: true)
                .Index(t => t.Recipient_Id)
                .Index(t => t.RecipientsList_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RecipientRecipientsLists", "RecipientsList_Id", "dbo.RecipientsLists");
            DropForeignKey("dbo.RecipientRecipientsLists", "Recipient_Id", "dbo.Recipients");
            DropIndex("dbo.RecipientRecipientsLists", new[] { "RecipientsList_Id" });
            DropIndex("dbo.RecipientRecipientsLists", new[] { "Recipient_Id" });
            DropTable("dbo.RecipientRecipientsLists");
            DropTable("dbo.Servers");
            DropTable("dbo.Senders");
            DropTable("dbo.MailMessages");
            DropTable("dbo.Recipients");
            DropTable("dbo.RecipientsLists");
        }
    }
}
