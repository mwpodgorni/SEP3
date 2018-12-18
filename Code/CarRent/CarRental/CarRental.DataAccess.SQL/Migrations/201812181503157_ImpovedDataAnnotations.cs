namespace CarRental.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImpovedDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "Street", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Addresses", "House", c => c.String(nullable: true, maxLength: 10));
            AlterColumn("dbo.Addresses", "City", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Addresses", "Postcode", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Addresses", "Country", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Cars", "Manufacturer", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Cars", "Model", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Cars", "Color", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Cars", "Type", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "PricePerDay", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Cars", "Image", c => c.String(nullable: false));
            AlterColumn("dbo.CarTypes", "Type", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Customers", "LastName", c => c.String(nullable: false));
            DropColumn("dbo.CarTypes", "Manufacturer");
            DropColumn("dbo.CarTypes", "Model");
            DropColumn("dbo.CarTypes", "ProductionYear");
            DropColumn("dbo.CarTypes", "Color");
            DropColumn("dbo.CarTypes", "Price");
            DropColumn("dbo.CarTypes", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CarTypes", "Image", c => c.String());
            AddColumn("dbo.CarTypes", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.CarTypes", "Color", c => c.String());
            AddColumn("dbo.CarTypes", "ProductionYear", c => c.Int(nullable: false));
            AddColumn("dbo.CarTypes", "Model", c => c.String());
            AddColumn("dbo.CarTypes", "Manufacturer", c => c.String());
            AlterColumn("dbo.Customers", "LastName", c => c.String());
            AlterColumn("dbo.CarTypes", "Type", c => c.String());
            AlterColumn("dbo.Cars", "Image", c => c.String());
            AlterColumn("dbo.Cars", "PricePerDay", c => c.Double(nullable: false));
            AlterColumn("dbo.Cars", "Type", c => c.String());
            AlterColumn("dbo.Cars", "Color", c => c.String());
            AlterColumn("dbo.Cars", "Model", c => c.String());
            AlterColumn("dbo.Cars", "Manufacturer", c => c.String());
            AlterColumn("dbo.Addresses", "Country", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "Postcode", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "House", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "Street", c => c.String(nullable: false));
        }
    }
}
