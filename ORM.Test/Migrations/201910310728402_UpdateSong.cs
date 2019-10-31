namespace ORM.Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSong : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Songs", "Duration", "Lenght");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.Songs", "Lenght", "Duration");
        }
    }
}
