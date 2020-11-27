namespace ApiSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createPostandCommenttable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Comment = c.String(),
                        PostId = c.Long(),
                        TotalLike = c.Decimal(precision: 18, scale: 2),
                        TotalDisLike = c.Decimal(precision: 18, scale: 2),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(),
                        EditBy = c.String(),
                        EditDate = c.DateTime(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Posts", t => t.PostId)
                .Index(t => t.PostId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PostTittle = c.String(),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(),
                        EditBy = c.String(),
                        EditDate = c.DateTime(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "PostId", "dbo.Posts");
            DropIndex("dbo.Comments", new[] { "PostId" });
            DropTable("dbo.Posts");
            DropTable("dbo.Comments");
        }
    }
}
