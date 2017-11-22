namespace Repo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedmessagetitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Message", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Message", "Title");
        }
    }
}
