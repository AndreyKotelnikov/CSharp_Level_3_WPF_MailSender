namespace MailSender.Lib.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateServer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Servers", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Servers", "Password");
        }
    }
}
