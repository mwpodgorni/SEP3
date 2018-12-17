namespace CarRental.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAddressToCustomerV3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Customers", new[] { "Address_Id" });
            AlterColumn("dbo.Addresses", "Street", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "House", c => c.String(nullable: true));
            AlterColumn("dbo.Addresses", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "Postcode", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "Country", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Address_Id", c => c.String(nullable: true, maxLength: 128));
            CreateIndex("dbo.Customers", "Address_Id");
            AddForeignKey("dbo.Customers", "Address_Id", "dbo.Addresses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Customers", new[] { "Address_Id" });
            AlterColumn("dbo.Customers", "Address_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "FirstName", c => c.String());
            AlterColumn("dbo.Addresses", "Country", c => c.String());
            AlterColumn("dbo.Addresses", "Postcode", c => c.String());
            AlterColumn("dbo.Addresses", "City", c => c.String());
            AlterColumn("dbo.Addresses", "House", c => c.String());
            AlterColumn("dbo.Addresses", "Street", c => c.String());
            CreateIndex("dbo.Customers", "Address_Id");
            AddForeignKey("dbo.Customers", "Address_Id", "dbo.Addresses", "Id");
        }
    }
}
