namespace CarRental_R.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddData1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RegisteredCustomers", "DateOfIssue", c => c.String(nullable: false));
            AlterColumn("dbo.RegisteredCustomers", "ExpiryDate", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RegisteredCustomers", "ExpiryDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.RegisteredCustomers", "DateOfIssue", c => c.DateTime(nullable: false));
        }
    }
}
