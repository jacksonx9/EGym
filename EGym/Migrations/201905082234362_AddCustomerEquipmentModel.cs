namespace EGym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerEquipmentModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        EquipmentName = c.String(),
                        EquipmentDescription = c.String(),
                        Availability = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Equipments");
            DropTable("dbo.Customers");
        }
    }
}
