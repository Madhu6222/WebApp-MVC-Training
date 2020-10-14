namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5f5c058a-0f05-49a0-817c-23a0d203bcca', N'guest@vidly.com', 0, N'AL873A2Q586McxAjP3foWFRUBen8YBeA1n6gwzrDr7XNSjShfeNxMRURnGHn/kyQQQ==', N'c782ba4f-7b17-4952-b8ba-ddfb8f89a18e', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8f541d88-09e7-4352-a2a5-18d72752c1a2', N'admin@vidly.com', 0, N'ADn8i/qqPKQ8i79csUCxsYaQ63Uj1T2eTQuaIp3ddaw8JnjUqiah1xlgMZaC8C4BcQ==', N'b0283d77-4123-4370-bd14-69d7ba33fea6', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'04677a0d-3727-4372-8865-7c66ed23b712', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8f541d88-09e7-4352-a2a5-18d72752c1a2', N'04677a0d-3727-4372-8865-7c66ed23b712')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
