namespace VMImpl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MitarbeiterEFImpls",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MitarbeiterAllgemeinEFImpls",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nummer = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NationEFImpls",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Bezeichnung = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NationEFImpls");
            DropTable("dbo.MitarbeiterAllgemeinEFImpls");
            DropTable("dbo.MitarbeiterEFImpls");
        }
    }
}
