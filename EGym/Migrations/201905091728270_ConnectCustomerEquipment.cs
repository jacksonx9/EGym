namespace EGym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConnectCustomerEquipment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipments", "CustomerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Equipments", "CustomerId");
            AddForeignKey("dbo.Equipments", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Equipments", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Equipments", new[] { "CustomerId" });
            DropColumn("dbo.Equipments", "CustomerId");
        }
    }
}
