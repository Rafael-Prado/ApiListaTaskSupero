namespace ListaTask.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriarBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Task",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Titulo = c.String(nullable: false, maxLength: 150),
                        Corpo = c.String(nullable: false, maxLength: 400),
                        Situacao = c.String(nullable: false),
                        DataCreate = c.DateTime(nullable: false),
                        DataFinalizacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Task");
        }
    }
}
