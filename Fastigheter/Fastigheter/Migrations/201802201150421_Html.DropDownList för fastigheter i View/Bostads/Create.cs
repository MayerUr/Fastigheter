namespace Fastigheter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HtmlDropDownListförfastigheteriViewBostadsCreate : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Bostads", "FastighetId");
            AddForeignKey("dbo.Bostads", "FastighetId", "dbo.Fastighets", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bostads", "FastighetId", "dbo.Fastighets");
            DropIndex("dbo.Bostads", new[] { "FastighetId" });
        }
    }
}
