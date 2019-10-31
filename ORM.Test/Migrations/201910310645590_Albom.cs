namespace ORM.Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Albom : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Songs", "Albom", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Songs", "Albom");
        }
    }
}
