namespace CarRental.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SoSickOfThisShitV2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rents",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        StartDate = c.DateTimeOffset(nullable: false, precision: 7),
                        EndDate = c.DateTimeOffset(nullable: false, precision: 7),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                        Car_Id = c.String(maxLength: 128),
                        Customer_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.Car_Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Car_Id)
                .Index(t => t.Customer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rents", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Rents", "Car_Id", "dbo.Cars");
            DropIndex("dbo.Rents", new[] { "Customer_Id" });
            DropIndex("dbo.Rents", new[] { "Car_Id" });
            DropTable("dbo.Rents");
        }
    }
}
