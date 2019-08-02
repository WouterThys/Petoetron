namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContactNameToCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "ContactName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "ContactName");
        }
    }
}
