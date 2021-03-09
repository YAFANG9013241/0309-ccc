namespace _0309一對多ccc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentID = c.Int(nullable: false),
                        Username = c.String(nullable: false, maxLength: 50),
                        Userpassword = c.String(nullable: false, maxLength: 50),
                        Usertel = c.String(nullable: false, maxLength: 50),
                        Useremail = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Users", new[] { "DepartmentID" });
            DropTable("dbo.Users");
        }
    }
}
