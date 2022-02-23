namespace MVC_Web_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustID = c.Int(nullable: false, identity: true),
                        CustName = c.String(maxLength: 64),
                    })
                .PrimaryKey(t => t.CustID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        orderId = c.Int(nullable: false, identity: true),
                        orderItemName = c.String(),
                        orderDesc = c.String(),
                    })
                .PrimaryKey(t => t.orderId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
            DropTable("dbo.Customer");
        }
    }
}
