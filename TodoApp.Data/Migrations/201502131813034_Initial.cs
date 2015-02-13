namespace TodoApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        CommentId = c.Long(nullable: false, identity: true),
                        CustomerId = c.Long(nullable: false),
                        Text = c.String(),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Customer", t => t.CustomerId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerId = c.Long(nullable: false, identity: true),
                        FirstName = c.String(),
                        Lastname = c.String(),
                        BirthDate = c.DateTime(),
                        Email = c.String(),
                        MobilePhone = c.String(),
                        FacebookUserID = c.String(maxLength: 20),
                        IsBlocked = c.Boolean(nullable: false),
                        IsWaitingFacebookRegistration = c.Boolean(nullable: false),
                        Password = c.String(),
                        AcceptsTerms = c.Boolean(),
                        DateActivated = c.DateTime(),
                        DateDeactivated = c.DateTime(),
                        LastSuccesfulLogin = c.DateTime(),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                        Todo_TodoId = c.Long(),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.FacebookToken", t => t.FacebookUserID)
                .ForeignKey("dbo.Todo", t => t.Todo_TodoId)
                .Index(t => t.FacebookUserID)
                .Index(t => t.Todo_TodoId);
            
            CreateTable(
                "dbo.FacebookToken",
                c => new
                    {
                        FacebookUserID = c.String(nullable: false, maxLength: 20),
                        AccessToken = c.String(),
                        Expires = c.DateTime(nullable: false),
                        MachineId = c.String(),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FacebookUserID);
            
            CreateTable(
                "dbo.Device",
                c => new
                    {
                        DeviceId = c.Long(nullable: false, identity: true),
                        DeviceGuid = c.Guid(nullable: false),
                        PushToken = c.String(),
                        PlatformId = c.Int(nullable: false),
                        Location = c.Geography(),
                        CustomerId = c.Long(),
                        AuthorizationToken = c.String(maxLength: 30),
                        IsLoggedIn = c.Boolean(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DeviceId)
                .ForeignKey("dbo.Customer", t => t.CustomerId)
                .ForeignKey("dbo.Platform", t => t.PlatformId)
                .Index(t => t.PlatformId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Platform",
                c => new
                    {
                        PlatformId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PlatformId);
            
            CreateTable(
                "dbo.Todo",
                c => new
                    {
                        TodoId = c.Long(nullable: false, identity: true),
                        Text = c.String(),
                        CreatedById = c.Long(nullable: false),
                        IsPublic = c.Boolean(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TodoId)
                .ForeignKey("dbo.Customer", t => t.CreatedById)
                .Index(t => t.CreatedById);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customer", "Todo_TodoId", "dbo.Todo");
            DropForeignKey("dbo.Todo", "CreatedById", "dbo.Customer");
            DropForeignKey("dbo.Device", "PlatformId", "dbo.Platform");
            DropForeignKey("dbo.Device", "CustomerId", "dbo.Customer");
            DropForeignKey("dbo.Comment", "CustomerId", "dbo.Customer");
            DropForeignKey("dbo.Customer", "FacebookUserID", "dbo.FacebookToken");
            DropIndex("dbo.Todo", new[] { "CreatedById" });
            DropIndex("dbo.Device", new[] { "CustomerId" });
            DropIndex("dbo.Device", new[] { "PlatformId" });
            DropIndex("dbo.Customer", new[] { "Todo_TodoId" });
            DropIndex("dbo.Customer", new[] { "FacebookUserID" });
            DropIndex("dbo.Comment", new[] { "CustomerId" });
            DropTable("dbo.Todo");
            DropTable("dbo.Platform");
            DropTable("dbo.Device");
            DropTable("dbo.FacebookToken");
            DropTable("dbo.Customer");
            DropTable("dbo.Comment");
        }
    }
}
