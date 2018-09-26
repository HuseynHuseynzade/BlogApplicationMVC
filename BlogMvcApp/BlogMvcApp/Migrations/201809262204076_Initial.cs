namespace BlogMvcApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Header = c.String(),
                        Description = c.String(),
                        İmage = c.String(),
                        Content = c.String(),
                        UploadDate = c.DateTime(nullable: false),
                        Approval = c.Boolean(nullable: false),
                        HomePage = c.Boolean(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blogs", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Blogs", new[] { "CategoryId" });
            DropTable("dbo.Categories");
            DropTable("dbo.Blogs");
        }
    }
}
