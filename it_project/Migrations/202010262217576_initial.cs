namespace it_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Price = c.Single(nullable: false),
                        Category = c.String(nullable: false),
                        Rating = c.Single(nullable: false),
                        ImageURL = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProductClients",
                c => new
                    {
                        Product_ID = c.Int(nullable: false),
                        Client_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_ID, t.Client_ID })
                .ForeignKey("dbo.Products", t => t.Product_ID, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_ID, cascadeDelete: true)
                .Index(t => t.Product_ID)
                .Index(t => t.Client_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductClients", "Client_ID", "dbo.Clients");
            DropForeignKey("dbo.ProductClients", "Product_ID", "dbo.Products");
            DropIndex("dbo.ProductClients", new[] { "Client_ID" });
            DropIndex("dbo.ProductClients", new[] { "Product_ID" });
            DropTable("dbo.ProductClients");
            DropTable("dbo.Products");
            DropTable("dbo.Clients");
        }
    }
}
