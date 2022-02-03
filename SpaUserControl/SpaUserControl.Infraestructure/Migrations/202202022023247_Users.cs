namespace SpaUserControl.Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Users : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 70, storeType: "nvarchar"),
                        Email = c.String(nullable: false, maxLength: 160, storeType: "nvarchar"),
                        Password = c.String(maxLength: 32, fixedLength: true, storeType: "nchar"),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true, name: "IX_EMAIL");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.User", "IX_EMAIL");
            DropTable("dbo.User");
        }
    }
}
