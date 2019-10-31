namespace ORM.Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateArtist : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Artists", "Surname", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Artists", "Surname");
        }
    }
}
