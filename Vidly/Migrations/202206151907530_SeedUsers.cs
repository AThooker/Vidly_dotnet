namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'30d6f606-a9bf-4263-9d7d-9f93c813c18d', N'guest@vidly.com', 0, N'AEI9wO6D7IoXbduioSzlKJfxioqCHucRBv/NQQ3RNWR0BC+/+ueiOAA1eF9pziPavw==', N'69de5190-11db-4a69-a828-3727f6c2a437', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'11834e1f-fe6c-43b9-91fa-49be0d7f29b4', N'admin@vidly.com', 0, N'AHZYLjlf7bwGeZKFIvvrR+JNhYO57Lvpo7OrONVVzT008cA62obsrDKRP0a3562azQ==', N'ba7d999d-a2fb-472f-8b8a-530a17ebd354', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f766160f-d965-41c3-a9b4-5aa9a7df57b1', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'11834e1f-fe6c-43b9-91fa-49be0d7f29b4', N'f766160f-d965-41c3-a9b4-5aa9a7df57b1')
                ");
        }

        public override void Down()
        {
        }
    }
}
