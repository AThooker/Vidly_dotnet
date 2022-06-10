namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulationGenreTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GenreId = c.Int(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        NumberInStock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Customers", "Birthday", c => c.DateTime());

            Sql("INSERT INTO Genres (Name) VALUES('Comedy') ");
            Sql("INSERT INTO Genres (Name) VALUES('Action') ");
            Sql("INSERT INTO Genres (Name) VALUES('Rom-Com') ");
            Sql("INSERT INTO Genres (Name) VALUES('Horror') ");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreId" });
            AlterColumn("dbo.Customers", "Birthday", c => c.DateTime(nullable: false));
            DropTable("dbo.Genres");
            DropTable("dbo.Movies");
        }
    }
}
