namespace MVC_Web_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        orderID = c.Int(nullable: false, identity: true),
                        orderItmName = c.String(),
                        orderDesc = c.String(),
                    })
                .PrimaryKey(t => t.orderID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Order");
            DropTable("dbo.Customer");
        }
    }
}
