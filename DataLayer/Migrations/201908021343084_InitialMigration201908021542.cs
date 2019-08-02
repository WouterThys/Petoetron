namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration201908021542 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Street = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        FixedPhone = c.String(),
                        MobilePhone = c.String(),
                        Vat = c.String(),
                        Description = c.String(),
                        Info = c.String(),
                        IconPath = c.String(),
                        Enabled = c.Boolean(nullable: false),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Unit = c.Int(nullable: false),
                        Weight = c.Double(nullable: false),
                        TypeId = c.Long(nullable: false),
                        Description = c.String(),
                        Info = c.String(),
                        IconPath = c.String(),
                        Enabled = c.Boolean(nullable: false),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MaterialTypes", t => t.TypeId, cascadeDelete: true)
                .Index(t => t.TypeId);
            
            CreateTable(
                "dbo.MaterialTypes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Description = c.String(),
                        Info = c.String(),
                        IconPath = c.String(),
                        Enabled = c.Boolean(nullable: false),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Materials", "TypeId", "dbo.MaterialTypes");
            DropIndex("dbo.Materials", new[] { "TypeId" });
            DropTable("dbo.MaterialTypes");
            DropTable("dbo.Materials");
            DropTable("dbo.Customers");
        }
    }
}
