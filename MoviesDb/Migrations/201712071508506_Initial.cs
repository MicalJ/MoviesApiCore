namespace MoviesDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Author = c.String(),
                        Year = c.Int(nullable: false),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rate = c.Short(nullable: false),
                        Comment = c.String(),
                        Movie_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.Movie_Id)
                .Index(t => t.Movie_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Movies", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Reviews", new[] { "Movie_Id" });
            DropIndex("dbo.Movies", new[] { "Category_Id" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Movies");
            DropTable("dbo.Categories");
        }
    }
}
