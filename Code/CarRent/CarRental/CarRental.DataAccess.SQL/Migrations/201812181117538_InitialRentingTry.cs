namespace CarRental.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialRentingTry : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "PricePerDay", c => c.Double(nullable: false));
            DropColumn("dbo.Cars", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Cars", "PricePerDay");
        }
    }
}
