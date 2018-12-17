namespace CarRental.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SoSickOfThisShit : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Customers", name: "Address_Id", newName: "AddressId");
            RenameIndex(table: "dbo.Customers", name: "IX_Address_Id", newName: "IX_AddressId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Customers", name: "IX_AddressId", newName: "IX_Address_Id");
            RenameColumn(table: "dbo.Customers", name: "AddressId", newName: "Address_Id");
        }
    }
}
