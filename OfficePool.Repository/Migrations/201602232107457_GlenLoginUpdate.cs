namespace OfficePool.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GlenLoginUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Logins", "Question", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Logins", "Question");
        }
    }
}
