namespace Rentalis_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPicture : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CarModels", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CarModels", "Image");
        }
    }
}
