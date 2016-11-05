namespace Padam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DurationInMonths = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Customers", "MembershipTypeID", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "MembershipType_ID", c => c.Int());
            CreateIndex("dbo.Customers", "MembershipType_ID");
            AddForeignKey("dbo.Customers", "MembershipType_ID", "dbo.MembershipTypes", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipType_ID", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipType_ID" });
            DropColumn("dbo.Customers", "MembershipType_ID");
            DropColumn("dbo.Customers", "MembershipTypeID");
            DropTable("dbo.MembershipTypes");
        }
    }
}
