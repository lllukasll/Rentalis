namespace Rentalis_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedInformationsForCars : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CarModels", "Doors", c => c.Byte());
            AddColumn("dbo.CarModels", "Seets", c => c.Byte());
            AddColumn("dbo.CarModels", "FuelType", c => c.Byte());
            AddColumn("dbo.CarModels", "Type", c => c.Byte());
            AddColumn("dbo.CarModels", "Abs", c => c.Boolean());
            AddColumn("dbo.CarModels", "PowerSteering", c => c.Boolean());
            AddColumn("dbo.CarModels", "GearBox", c => c.Boolean());
            AddColumn("dbo.CarModels", "AirConditioning", c => c.Boolean());
            AddColumn("dbo.CarModels", "CentralLocking", c => c.Boolean());
            AddColumn("dbo.CarModels", "AirBags", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CarModels", "AirBags");
            DropColumn("dbo.CarModels", "CentralLocking");
            DropColumn("dbo.CarModels", "AirConditioning");
            DropColumn("dbo.CarModels", "GearBox");
            DropColumn("dbo.CarModels", "PowerSteering");
            DropColumn("dbo.CarModels", "Abs");
            DropColumn("dbo.CarModels", "Type");
            DropColumn("dbo.CarModels", "FuelType");
            DropColumn("dbo.CarModels", "Seets");
            DropColumn("dbo.CarModels", "Doors");
        }
    }
}
