namespace _0309一對多ccc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cusname = c.String(nullable: false, maxLength: 50),
                        Cuspassword = c.String(nullable: false, maxLength: 50),
                        Custel = c.String(nullable: false, maxLength: 50),
                        Cusemail = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Departmentname = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Departments");
            DropTable("dbo.Cus");
        }
    }
}
