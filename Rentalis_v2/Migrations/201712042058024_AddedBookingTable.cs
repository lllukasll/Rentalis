namespace Rentalis_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBookingTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookingModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        carId = c.Int(nullable: false),
                        userId = c.Int(nullable: false),
                        DateTimeFrom = c.DateTime(nullable: false, precision: 0),
                        DateTimeTo = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BookingModels");
        }
    }
}
