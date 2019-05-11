namespace EGym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0010f45e-67c6-4cbe-b311-69c6cd6c623c', N'admin@hotmail.com', 0, N'ANTJyaegWNwwAI+y4PBbok+chPmLlEJVA5tKFle0nhE+n9zHlAN/2ILwZi0G02xTSA==', N'0309da03-7c5f-4ffc-94f7-b717ba0a9cb5', NULL, 0, 0, NULL, 1, 0, N'admin@hotmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'99801d58-8266-4e7a-8658-52ab4fabfd80', N'guest@hotmail.com', 0, N'APizZsIMOo9aj+8kZXEvU9+7Bf7Meh0DsRz77MBsv717nZQ90jqeXCCau3fWzjDYXA==', N'965ece5d-608a-4de5-85c6-4fce7aa36e95', NULL, 0, 0, NULL, 1, 0, N'guest@hotmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0461a41f-901a-45af-9f5d-2f62cd50e513', N'CanManageEquipment')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0010f45e-67c6-4cbe-b311-69c6cd6c623c', N'0461a41f-901a-45af-9f5d-2f62cd50e513')
");
        }
        
        public override void Down()
        {
        }
    }
}
