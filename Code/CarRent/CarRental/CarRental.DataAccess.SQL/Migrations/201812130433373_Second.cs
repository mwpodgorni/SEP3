namespace CarRental.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.CarTypes", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CarTypes", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Cars", "CreatedAt", c => c.DateTime(nullable: false));
        }
    }
}
