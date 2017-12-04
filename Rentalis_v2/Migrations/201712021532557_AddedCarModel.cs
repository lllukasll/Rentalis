namespace Rentalis_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCarModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Description = c.String(unicode: false),
                        ProductionYear = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CarModels");
        }
    }
}
