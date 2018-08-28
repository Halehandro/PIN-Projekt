namespace TechMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodavanjePodatakaTest : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Phones (Name, Model, Price) VALUES('OnePlus', '3t', '420'); ");
        }
        
        public override void Down()
        {
        }
    }
}
