namespace Rentalis_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CarModels", "Description", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CarModels", "Description", c => c.String(nullable: false, unicode: false));
        }
    }
}
