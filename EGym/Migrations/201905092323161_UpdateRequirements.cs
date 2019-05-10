namespace EGym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRequirements : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Equipments", "Photo", c => c.String(maxLength: 30));
            AlterColumn("dbo.Equipments", "Description", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Equipments", "Description", c => c.String());
            AlterColumn("dbo.Equipments", "Photo", c => c.String());
        }
    }
}
