namespace CarRental_R.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class registeredCustomers : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Customers", newName: "RegisteredCustomers");
            AlterColumn("dbo.RegisteredCustomers", "Password", c => c.String(nullable: false));
            DropColumn("dbo.RegisteredCustomers", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RegisteredCustomers", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.RegisteredCustomers", "Password", c => c.String());
            RenameTable(name: "dbo.RegisteredCustomers", newName: "Customers");
        }
    }
}
