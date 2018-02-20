namespace Fastigheter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seeds : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bostads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FastighetId = c.Int(nullable: false),
                        Nummer = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fastighets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Land = c.String(),
                        Gatuadress = c.String(),
                        Postnummer = c.Int(nullable: false),
                        Postort = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fastighets");
            DropTable("dbo.Bostads");
        }
    }
}
