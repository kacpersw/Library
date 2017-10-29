namespace Repo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Author",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        ISBN = c.String(),
                        Title = c.String(),
                        Loaned = c.Boolean(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Borrow",
                c => new
                    {
                        BorrowId = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        BorrowStart = c.DateTime(nullable: false),
                        BorrowEnd = c.DateTime(nullable: false),
                        State = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.BorrowId)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        Name = c.String(),
                        Surname = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Cart",
                c => new
                    {
                        CartId = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CartId)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.File",
                c => new
                    {
                        FileId = c.Int(nullable: false, identity: true),
                        Content = c.Binary(),
                    })
                .PrimaryKey(t => t.FileId);
            
            CreateTable(
                "dbo.Limit",
                c => new
                    {
                        LimitId = c.Int(nullable: false, identity: true),
                        MaxBorrowBooks = c.Int(nullable: false),
                        MaxWaitingBooks = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LimitId);
            
            CreateTable(
                "dbo.Queue",
                c => new
                    {
                        QueueId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.QueueId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.Search",
                c => new
                    {
                        SearchId = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        SearchDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SearchId);
            
            CreateTable(
                "dbo.Tag",
                c => new
                    {
                        TagId = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.TagId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Cart", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Borrow", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Book", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Cart", new[] { "User_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Borrow", new[] { "User_Id" });
            DropIndex("dbo.Book", new[] { "User_Id" });
            DropTable("dbo.Tag");
            DropTable("dbo.Search");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Queue");
            DropTable("dbo.Limit");
            DropTable("dbo.File");
            DropTable("dbo.Cart");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Borrow");
            DropTable("dbo.Book");
            DropTable("dbo.Author");
        }
    }
}
