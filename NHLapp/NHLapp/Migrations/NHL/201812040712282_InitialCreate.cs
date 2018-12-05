namespace NHLapp.Migrations.NHL
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayerId = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        Position = c.String(),
                        TeamName = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.PlayerId)
                .ForeignKey("dbo.Teams", t => t.TeamName)
                .Index(t => t.TeamName);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamName = c.String(nullable: false, maxLength: 30),
                        City = c.String(),
                        Province = c.String(),
                    })
                .PrimaryKey(t => t.TeamName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "TeamName", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "TeamName" });
            DropTable("dbo.Teams");
            DropTable("dbo.Players");
        }
    }
}
