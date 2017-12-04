namespace Rentalis_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDoorsNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CarModels", "Doors", c => c.Byte());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CarModels", "Doors");
        }
    }
}
