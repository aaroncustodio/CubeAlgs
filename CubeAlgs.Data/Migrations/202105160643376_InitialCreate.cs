namespace CubeAlgs.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Algorithm",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CaseId = c.Guid(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Case", t => t.CaseId)
                .Index(t => t.CaseId);
            
            CreateTable(
                "dbo.Case",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Group",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SetId = c.Guid(),
                        Name = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Set", t => t.SetId)
                .Index(t => t.SetId);
            
            CreateTable(
                "dbo.Set",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        IsCustom = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Group", "SetId", "dbo.Set");
            DropForeignKey("dbo.Algorithm", "CaseId", "dbo.Case");
            DropIndex("dbo.Group", new[] { "SetId" });
            DropIndex("dbo.Algorithm", new[] { "CaseId" });
            DropTable("dbo.Set");
            DropTable("dbo.Group");
            DropTable("dbo.Case");
            DropTable("dbo.Algorithm");
        }
    }
}
