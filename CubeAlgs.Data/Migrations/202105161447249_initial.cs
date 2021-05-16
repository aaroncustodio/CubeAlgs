namespace CubeAlgs.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Case", "SetId", c => c.Guid(nullable: false));
            AddColumn("dbo.Case", "GroupId", c => c.Guid());
            CreateIndex("dbo.Case", "SetId");
            CreateIndex("dbo.Case", "GroupId");
            AddForeignKey("dbo.Case", "GroupId", "dbo.Group", "Id");
            AddForeignKey("dbo.Case", "SetId", "dbo.Set", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Case", "SetId", "dbo.Set");
            DropForeignKey("dbo.Case", "GroupId", "dbo.Group");
            DropIndex("dbo.Case", new[] { "GroupId" });
            DropIndex("dbo.Case", new[] { "SetId" });
            DropColumn("dbo.Case", "GroupId");
            DropColumn("dbo.Case", "SetId");
        }
    }
}
