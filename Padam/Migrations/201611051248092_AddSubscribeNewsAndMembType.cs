namespace Padam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSubscribeNewsAndMembType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubscribedToNewsletter");
        }
    }
}
