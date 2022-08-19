namespace billsystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bills", "Date", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Clients", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Items", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Types", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Companies", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Units", "Name", c => c.String(nullable: false));
           // CreateIndex("dbo.Clients", "Name", unique: true, name: "Ix_ClientName");
          //  CreateIndex("dbo.Employees", "Name", unique: true, name: "Ix_EmpName");
          //  CreateIndex("dbo.Items", "Name", unique: true, name: "Ix_ItemName");
         //   CreateIndex("dbo.Types", "Name", unique: true, name: "Ix_TypeName");
         //   CreateIndex("dbo.Companies", "Name", unique: true, name: "Ix_CompanyName");
         //   CreateIndex("dbo.Units", "Name", unique: true, name: "Ix_UnitName");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Units", "Ix_UnitName");
            DropIndex("dbo.Companies", "Ix_CompanyName");
            DropIndex("dbo.Types", "Ix_TypeName");
            DropIndex("dbo.Items", "Ix_ItemName");
            DropIndex("dbo.Employees", "Ix_EmpName");
            DropIndex("dbo.Clients", "Ix_ClientName");
            AlterColumn("dbo.Units", "Name", c => c.String());
            AlterColumn("dbo.Companies", "Name", c => c.String());
            AlterColumn("dbo.Types", "Name", c => c.String());
            AlterColumn("dbo.Items", "Name", c => c.String());
            AlterColumn("dbo.Employees", "Name", c => c.String());
            AlterColumn("dbo.Clients", "Address", c => c.String());
            AlterColumn("dbo.Clients", "Name", c => c.String());
            AlterColumn("dbo.Bills", "Date", c => c.DateTime(nullable: false));
        }
    }
}
