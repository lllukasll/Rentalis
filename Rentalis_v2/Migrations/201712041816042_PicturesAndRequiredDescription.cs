namespace Rentalis_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PicturesAndRequiredDescription : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CarModels", "Description", c => c.String(nullable: false, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CarModels", "Description", c => c.String(unicode: false));
        }
    }
}
