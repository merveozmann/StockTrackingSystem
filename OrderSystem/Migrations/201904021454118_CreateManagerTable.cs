namespace OrderStockSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateManagerTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Customer_Id = c.Int(nullable: false, identity: true),
                        Customer_Kode = c.Int(nullable: false),
                        Company_Name = c.String(),
                        Telephone = c.Int(nullable: false),
                        Mobile_Phone = c.Int(nullable: false),
                        Mail = c.String(),
                        Authorized_Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Customer_Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Sales_Id = c.Int(nullable: false, identity: true),
                        Payment_Kode = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        OrderKode = c.Int(nullable: false),
                        KDV_Amount = c.Double(nullable: false),
                        Payment_Amount = c.Double(nullable: false),
                        Remain_Amount = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Explation = c.String(),
                        State = c.Byte(nullable: false),
                        Collection_Date = c.DateTime(nullable: false),
                        Forwarding_Amount = c.Double(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        CustomerKode = c.Int(nullable: false),
                        ProductKode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Sales_Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.SalesOrders", t => t.OrderId, cascadeDelete: false)
                .Index(t => t.OrderId)
                .Index(t => t.CustomerId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Product_Id = c.Int(nullable: false, identity: true),
                        Product_Kode = c.Int(nullable: false),
                        Product_Name = c.String(),
                        Amount = c.Int(nullable: false),
                        Memory = c.String(),
                        Usage_Area = c.String(),
                        Disk_Capacity = c.String(),
                        Rotation_Speed = c.String(),
                        Warranty = c.Int(nullable: false),
                        Size = c.String(),
                    })
                .PrimaryKey(t => t.Product_Id);
            
            CreateTable(
                "dbo.SalesOrders",
                c => new
                    {
                        Order_Id = c.Int(nullable: false, identity: true),
                        Order_Kode = c.Int(nullable: false),
                        Sales_Piece = c.Int(nullable: false),
                        Unit_Price = c.Double(nullable: false),
                        Sales_Date = c.DateTime(nullable: false),
                        KDV_Rate = c.Double(nullable: false),
                        Sales_Total = c.Double(nullable: false),
                        Sales_KDV_Total = c.Double(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        CustomerKode = c.Int(nullable: false),
                        ProductKode = c.Int(nullable: false),
                        Control = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Order_Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Stock_Id = c.Int(nullable: false, identity: true),
                        Stock_Kode = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Stock_Date = c.DateTime(nullable: false),
                        KDV_Rate = c.Double(nullable: false),
                        SuppliersId = c.Int(nullable: false),
                        SuppliersKode = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        ProductKode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Stock_Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SuppliersId, cascadeDelete: true)
                .Index(t => t.SuppliersId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Suppliers_Id = c.Int(nullable: false, identity: true),
                        Suppliers_kode = c.Int(nullable: false),
                        Company_Name = c.String(),
                        Telephone = c.Int(nullable: false),
                        Authorized_Name = c.String(),
                        Authorized_Telephone = c.Int(nullable: false),
                        Mail = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Suppliers_Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Employee_Id = c.Int(nullable: false, identity: true),
                        Name_Surname = c.String(),
                        Degree = c.String(),
                        Mail = c.String(),
                        Star_Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Employee_Id);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        Manager_Id = c.Int(nullable: false, identity: true),
                        Name_Surname = c.String(),
                        User_Adi = c.String(),
                        Password = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Manager_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        User_Id = c.Int(nullable: false, identity: true),
                        Password = c.Int(nullable: false),
                        Status = c.Byte(nullable: false),
                        Name_Surname = c.String(),
                        Telephone = c.Int(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "OrderId", "dbo.SalesOrders");
            DropForeignKey("dbo.Sales", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Stocks", "SuppliersId", "dbo.Suppliers");
            DropForeignKey("dbo.Stocks", "ProductId", "dbo.Products");
            DropForeignKey("dbo.SalesOrders", "ProductId", "dbo.Products");
            DropForeignKey("dbo.SalesOrders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Sales", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Stocks", new[] { "ProductId" });
            DropIndex("dbo.Stocks", new[] { "SuppliersId" });
            DropIndex("dbo.SalesOrders", new[] { "ProductId" });
            DropIndex("dbo.SalesOrders", new[] { "CustomerId" });
            DropIndex("dbo.Sales", new[] { "ProductId" });
            DropIndex("dbo.Sales", new[] { "CustomerId" });
            DropIndex("dbo.Sales", new[] { "OrderId" });
            DropTable("dbo.Users");
            DropTable("dbo.Managers");
            DropTable("dbo.Employees");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Stocks");
            DropTable("dbo.SalesOrders");
            DropTable("dbo.Products");
            DropTable("dbo.Sales");
            DropTable("dbo.Customers");
        }
    }
}
