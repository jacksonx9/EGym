namespace EGym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name) VALUES ('Jackson')");
            Sql("INSERT INTO Customers (Name) VALUES ('David')");
            Sql("INSERT INTO Customers (Name) VALUES ('Sam')");
            Sql("INSERT INTO Customers (Name) VALUES ('Allison')");
        }
        
        public override void Down()
        {
        }
    }
}
