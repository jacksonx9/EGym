namespace EGym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCustomerEquipmentRelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Equipments", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Equipments", new[] { "CustomerId" });
            DropColumn("dbo.Equipments", "CustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Equipments", "CustomerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Equipments", "CustomerId");
            AddForeignKey("dbo.Equipments", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
