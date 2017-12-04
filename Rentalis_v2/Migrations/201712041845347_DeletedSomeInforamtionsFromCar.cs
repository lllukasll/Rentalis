namespace Rentalis_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedSomeInforamtionsFromCar : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CarModels", "Abs", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CarModels", "PowerSteering", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CarModels", "AirConditioning", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CarModels", "CentralLocking", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CarModels", "AirBags", c => c.Boolean(nullable: false));
            DropColumn("dbo.CarModels", "Doors");
            DropColumn("dbo.CarModels", "Seets");
            DropColumn("dbo.CarModels", "FuelType");
            DropColumn("dbo.CarModels", "Type");
            DropColumn("dbo.CarModels", "GearBox");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CarModels", "GearBox", c => c.Boolean());
            AddColumn("dbo.CarModels", "Type", c => c.Byte());
            AddColumn("dbo.CarModels", "FuelType", c => c.Byte());
            AddColumn("dbo.CarModels", "Seets", c => c.Byte());
            AddColumn("dbo.CarModels", "Doors", c => c.Byte());
            AlterColumn("dbo.CarModels", "AirBags", c => c.Boolean());
            AlterColumn("dbo.CarModels", "CentralLocking", c => c.Boolean());
            AlterColumn("dbo.CarModels", "AirConditioning", c => c.Boolean());
            AlterColumn("dbo.CarModels", "PowerSteering", c => c.Boolean());
            AlterColumn("dbo.CarModels", "Abs", c => c.Boolean());
        }
    }
}
