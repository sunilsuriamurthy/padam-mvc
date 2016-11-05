namespace Padam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyMembershipTypeId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MembershipType_ID", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipType_ID" });
            DropColumn("dbo.Customers", "MembershipTypeID");
            RenameColumn(table: "dbo.Customers", name: "MembershipType_ID", newName: "MembershipTypeID");
            DropPrimaryKey("dbo.MembershipTypes");
            AlterColumn("dbo.Customers", "MembershipTypeID", c => c.Byte(nullable: false));
            AlterColumn("dbo.MembershipTypes", "ID", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.MembershipTypes", "ID");
            CreateIndex("dbo.Customers", "MembershipTypeID");
            AddForeignKey("dbo.Customers", "MembershipTypeID", "dbo.MembershipTypes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeID", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeID" });
            DropPrimaryKey("dbo.MembershipTypes");
            AlterColumn("dbo.MembershipTypes", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Customers", "MembershipTypeID", c => c.Int());
            AddPrimaryKey("dbo.MembershipTypes", "ID");
            RenameColumn(table: "dbo.Customers", name: "MembershipTypeID", newName: "MembershipType_ID");
            AddColumn("dbo.Customers", "MembershipTypeID", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MembershipType_ID");
            AddForeignKey("dbo.Customers", "MembershipType_ID", "dbo.MembershipTypes", "ID");
        }
    }
}
