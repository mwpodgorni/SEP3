namespace CarRental.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNameForCars : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Name", c => c.String(maxLength: 40));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Name");
        }
    }
}
