namespace Padam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Name, DurationInMonths, SignUpFee, DiscountRate) VALUES('Pay As You Go', 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes(Name, DurationInMonths, SignUpFee, DiscountRate) VALUES('Monthly', 1, 30, 10)");
            Sql("INSERT INTO MembershipTypes(Name, DurationInMonths, SignUpFee, DiscountRate) VALUES('Quarterly', 3, 80, 15)");
            Sql("INSERT INTO MembershipTypes(Name, DurationInMonths, SignUpFee, DiscountRate) VALUES('Yearly', 12, 300, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
