namespace CarRental.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAddressToCustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Street = c.String(),
                        House = c.String(),
                        City = c.String(),
                        Postcode = c.String(),
                        Country = c.String(),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "Address_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Customers", "Address_Id");
            AddForeignKey("dbo.Customers", "Address_Id", "dbo.Addresses", "Id");
            DropColumn("dbo.Customers", "Street");
            DropColumn("dbo.Customers", "City");
            DropColumn("dbo.Customers", "Country");
            DropColumn("dbo.Customers", "ZipCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "ZipCode", c => c.String());
            AddColumn("dbo.Customers", "Country", c => c.String());
            AddColumn("dbo.Customers", "City", c => c.String());
            AddColumn("dbo.Customers", "Street", c => c.String());
            DropForeignKey("dbo.Customers", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Customers", new[] { "Address_Id" });
            DropColumn("dbo.Customers", "Address_Id");
            DropTable("dbo.Addresses");
        }
    }
}
