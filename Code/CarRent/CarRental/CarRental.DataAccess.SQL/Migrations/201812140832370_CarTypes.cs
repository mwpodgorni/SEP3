namespace CarRental.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarTypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Country", c => c.String());
            DropColumn("dbo.Customers", "State");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "State", c => c.String());
            DropColumn("dbo.Customers", "Country");
        }
    }
}
