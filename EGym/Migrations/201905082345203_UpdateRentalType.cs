namespace EGym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRentalType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO RentalTypes (Id, RentalFee) VALUES (1, 0.1)");
            Sql("INSERT INTO RentalTypes (Id, RentalFee) VALUES (2, 0.15)");
            Sql("INSERT INTO RentalTypes (Id, RentalFee) VALUES (3, 0.2)");
            Sql("INSERT INTO RentalTypes (Id, RentalFee) VALUES (4, 0.25)");
            Sql("INSERT INTO RentalTypes (Id, RentalFee) VALUES (5, 0.3)");
            Sql("INSERT INTO RentalTypes (Id, RentalFee) VALUES (6, 0.35)");
        }
        
        public override void Down()
        {
        }
    }
}
