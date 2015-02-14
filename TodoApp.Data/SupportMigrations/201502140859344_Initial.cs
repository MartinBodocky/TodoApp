namespace TodoApp.Data.SupportMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CommunicationLog",
                c => new
                    {
                        CommunicationLogId = c.Long(nullable: false, identity: true),
                        DeviceGuid = c.Guid(nullable: false),
                        CorrelationId = c.Guid(nullable: false),
                        ExceptionLogId = c.Guid(),
                        Address = c.String(),
                        Message = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        Ip = c.String(maxLength: 50),
                        Result = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.CommunicationLogId);
            
            CreateTable(
                "dbo.ExceptionLog",
                c => new
                    {
                        ExceptionLogId = c.Guid(nullable: false),
                        Message = c.String(nullable: false),
                        Details = c.String(),
                        StackTrace = c.String(),
                        DeviceGuid = c.Guid(),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ExceptionLogId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ExceptionLog");
            DropTable("dbo.CommunicationLog");
        }
    }
}
