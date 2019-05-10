namespace EGym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Equipments", "Name", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Equipments", "Name", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
