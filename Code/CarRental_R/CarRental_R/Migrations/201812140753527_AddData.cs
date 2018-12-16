namespace CarRental_R.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Cars (PlatesNumber,Type, Color, FuelType, GearBox, EngineCapacity, Model, NumberOfDoors) VALUES ('KLI123', 'Sedan', 'black', 'Diesel', 'Manual', 2500, 'BMW e46', 3)");
            Sql("INSERT INTO RegisteredCustomers (IdNumber,Type, FirstName, LastName, Age, Email, Country, Address, PostCode, PhoneNumber, DateOfIssue, EpiryDate, Password) VALUES ('AZAI123', 'Michal', 'Podgorni', 20, 'mwpodgorni@gmail.com', 'Denmark', 'Sondergade 31 B3', '8700 Horsens', 50265805, '25-05-2015', '25-05-2026', 'password' )");
        }
        
        public override void Down()
        {
        }
    }
}
