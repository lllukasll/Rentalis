namespace Rentalis_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedInformations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CarModels", "Seets", c => c.Byte());
            AddColumn("dbo.CarModels", "FuelType", c => c.Byte());
            AddColumn("dbo.CarModels", "Type", c => c.Byte());
            AddColumn("dbo.CarModels", "GearBox", c => c.Byte());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CarModels", "GearBox");
            DropColumn("dbo.CarModels", "Type");
            DropColumn("dbo.CarModels", "FuelType");
            DropColumn("dbo.CarModels", "Seets");
        }
    }
}
