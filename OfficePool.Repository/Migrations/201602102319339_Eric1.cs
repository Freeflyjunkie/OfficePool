namespace OfficePool.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Eric1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameId = c.Int(nullable: false, identity: true),
                        FavoredTeamId = c.Int(nullable: false),
                        Spread = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnderdogTeamId = c.Int(nullable: false),
                        GameDate = c.DateTime(nullable: false),
                        IsHomeTeamFavorite = c.Boolean(nullable: false),
                        TotalPoints = c.Int(nullable: false),
                        IsTieBreaker = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.GameId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teams");
            DropTable("dbo.Games");
        }
    }
}
