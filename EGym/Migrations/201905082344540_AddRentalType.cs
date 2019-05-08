namespace EGym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRentalType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RentalTypes", "RentalFee", c => c.Double(nullable: false));
            DropColumn("dbo.RentalTypes", "DurationInMinutes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RentalTypes", "DurationInMinutes", c => c.Int(nullable: false));
            AlterColumn("dbo.RentalTypes", "RentalFee", c => c.Short(nullable: false));
        }
    }
}
