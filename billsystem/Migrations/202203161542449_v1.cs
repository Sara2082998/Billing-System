namespace billsystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bill_Item",
                c => new
                    {
                        Item_Id = c.Int(nullable: false),
                        Bill_Id = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Item_Id, t.Bill_Id })
                .ForeignKey("dbo.Bills", t => t.Bill_Id, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.Item_Id, cascadeDelete: true)
                .Index(t => t.Item_Id)
                .Index(t => t.Bill_Id);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Client_Id = c.Int(nullable: false),
                        Emp_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.Emp_Id, cascadeDelete: true)
                .Index(t => t.Client_Id)
                .Index(t => t.Emp_Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Selling_Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Buying_Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Notes = c.String(),
                        Type_Id = c.Int(nullable: false),
                        Unit_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Types", t => t.Type_Id, cascadeDelete: true)
                .ForeignKey("dbo.Units", t => t.Unit_Id, cascadeDelete: true)
                .Index(t => t.Type_Id)
                .Index(t => t.Unit_Id);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Notes = c.String(),
                        Comp_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Comp_Id, cascadeDelete: true)
                .Index(t => t.Comp_Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bill_Item", "Item_Id", "dbo.Items");
            DropForeignKey("dbo.Items", "Unit_Id", "dbo.Units");
            DropForeignKey("dbo.Items", "Type_Id", "dbo.Types");
            DropForeignKey("dbo.Types", "Comp_Id", "dbo.Companies");
            DropForeignKey("dbo.Bill_Item", "Bill_Id", "dbo.Bills");
            DropForeignKey("dbo.Bills", "Emp_Id", "dbo.Employees");
            DropForeignKey("dbo.Bills", "Client_Id", "dbo.Clients");
            DropIndex("dbo.Types", new[] { "Comp_Id" });
            DropIndex("dbo.Items", new[] { "Unit_Id" });
            DropIndex("dbo.Items", new[] { "Type_Id" });
            DropIndex("dbo.Bills", new[] { "Emp_Id" });
            DropIndex("dbo.Bills", new[] { "Client_Id" });
            DropIndex("dbo.Bill_Item", new[] { "Bill_Id" });
            DropIndex("dbo.Bill_Item", new[] { "Item_Id" });
            DropTable("dbo.Units");
            DropTable("dbo.Companies");
            DropTable("dbo.Types");
            DropTable("dbo.Items");
            DropTable("dbo.Employees");
            DropTable("dbo.Clients");
            DropTable("dbo.Bills");
            DropTable("dbo.Bill_Item");
        }
    }
}
