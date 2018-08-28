namespace TechMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodavnjePodatakaUBazu : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Phones (Name, Model, Price) VALUES('Iphone', 'X', '1000'); ");
            Sql("INSERT INTO Phones (Name, Model, Price) VALUES('Samsung', 'S9', '750'); ");
            Sql("INSERT INTO Phones (Name, Model, Price) VALUES('Xiaomi', 'Redmi note 4', '220'); ");
            Sql("INSERT INTO Phones (Name, Model, Price) VALUES('Nokia', '3310', '20'); ");
            Sql("INSERT INTO Phones (Name, Model, Price) VALUES('OnePlus', 'One', '300'); ");
            Sql("INSERT INTO Phones (Name, Model, Price) VALUES('Huawei', 'P20', '550'); ");
            Sql("INSERT INTO Phones (Name, Model, Price) VALUES('LG', 'G6', '320'); ");
            Sql("INSERT INTO Phones (Name, Model, Price) VALUES('Huawei', 'P20 Pro', '650'); ");
            Sql("INSERT INTO Phones (Name, Model, Price) VALUES('LG', 'V30', '630'); ");
            Sql("INSERT INTO Phones (Name, Model, Price) VALUES('Xiaomi', 'Mi5s Plus', '360'); ");
            Sql("INSERT INTO Phones (Name, Model, Price) VALUES('Google', 'Pixel XL', '680'); ");
            Sql("INSERT INTO Phones (Name, Model, Price) VALUES('Motorola', 'Nexus P', '720'); ");
            Sql("INSERT INTO Phones (Name, Model, Price) VALUES('Nokia', '9', '550'); ");
            Sql("INSERT INTO Phones (Name, Model, Price) VALUES('Huawei', 'Mate 10', '920'); ");
            Sql("INSERT INTO Phones (Name, Model, Price) VALUES('Samsung', 'Galaxy Note 7', '1'); ");

        }
        
        public override void Down()
        {
        }
    }
}
