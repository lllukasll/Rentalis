namespace Rentalis_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDataAnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CarModels", "Name", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.CarModels", "Description", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.CarModels", "ProductionYear", c => c.String(nullable: false, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CarModels", "ProductionYear", c => c.String(unicode: false));
            AlterColumn("dbo.CarModels", "Description", c => c.String(unicode: false));
            AlterColumn("dbo.CarModels", "Name", c => c.String(unicode: false));
        }
    }
}
