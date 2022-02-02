namespace it_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeEmailDisplay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "EmailAddress", c => c.String(nullable: false));
            DropColumn("dbo.Clients", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "Email", c => c.String(nullable: false));
            DropColumn("dbo.Clients", "EmailAddress");
        }
    }
}
