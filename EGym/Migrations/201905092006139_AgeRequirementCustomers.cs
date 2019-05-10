namespace EGym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgeRequirementCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsOver19", c => c.Boolean(nullable: false));
            AddColumn("dbo.Equipments", "Name", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Equipments", "Description", c => c.String());
            DropColumn("dbo.Equipments", "EquipmentName");
            DropColumn("dbo.Equipments", "EquipmentDescription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Equipments", "EquipmentDescription", c => c.String());
            AddColumn("dbo.Equipments", "EquipmentName", c => c.String(nullable: false, maxLength: 30));
            DropColumn("dbo.Equipments", "Description");
            DropColumn("dbo.Equipments", "Name");
            DropColumn("dbo.Customers", "IsOver19");
        }
    }
}
