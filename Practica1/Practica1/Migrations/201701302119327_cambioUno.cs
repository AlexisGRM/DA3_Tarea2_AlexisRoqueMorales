namespace Practica1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambioUno : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Especificaciones",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        modelo = c.String(),
                        costo = c.String(),
                        ram = c.String(),
                        procesador = c.String(),
                        hdd = c.String(),
                        dimensiones = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Estados",
                c => new
                    {
                        estadoID = c.Int(nullable: false, identity: true),
                        nombreEstado = c.String(),
                    })
                .PrimaryKey(t => t.estadoID);
            
            CreateTable(
                "dbo.Municipios",
                c => new
                    {
                        municipioID = c.Int(nullable: false, identity: true),
                        nombreMunicipio = c.String(),
                        estadoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.municipioID)
                .ForeignKey("dbo.Estados", t => t.estadoID, cascadeDelete: true)
                .Index(t => t.estadoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Municipios", "estadoID", "dbo.Estados");
            DropIndex("dbo.Municipios", new[] { "estadoID" });
            DropTable("dbo.Municipios");
            DropTable("dbo.Estados");
            DropTable("dbo.Especificaciones");
        }
    }
}
