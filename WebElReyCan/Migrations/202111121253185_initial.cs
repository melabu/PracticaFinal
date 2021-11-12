namespace WebElReyCan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Turno",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false, storeType: "date"),
                        NombreMascota = c.String(nullable: false, maxLength: 8000, unicode: false),
                        NombreDuenio = c.String(nullable: false, maxLength: 8000, unicode: false),
                        Raza = c.String(maxLength: 8000, unicode: false),
                        EdadMascota = c.Int(nullable: false),
                        Celular = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Turno");
        }
    }
}
