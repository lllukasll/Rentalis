namespace Rentalis_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedShortDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CarModels", "ShortDescription", c => c.String(nullable: false, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CarModels", "ShortDescription");
        }
    }
}
