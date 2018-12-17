namespace CarRental.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDtos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CarTypes", "Manufacturer", c => c.String());
            AddColumn("dbo.CarTypes", "Model", c => c.String());
            AddColumn("dbo.CarTypes", "ProductionYear", c => c.Int(nullable: false));
            AddColumn("dbo.CarTypes", "Color", c => c.String());
            AddColumn("dbo.CarTypes", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.CarTypes", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CarTypes", "Image");
            DropColumn("dbo.CarTypes", "Price");
            DropColumn("dbo.CarTypes", "Color");
            DropColumn("dbo.CarTypes", "ProductionYear");
            DropColumn("dbo.CarTypes", "Model");
            DropColumn("dbo.CarTypes", "Manufacturer");
        }
    }
}
