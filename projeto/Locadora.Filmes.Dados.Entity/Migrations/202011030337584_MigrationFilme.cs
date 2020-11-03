namespace Locadora.Filmes.Dados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationFilme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Album",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Ano = c.Int(nullable: false),
                        Descricao = c.String(maxLength: 1000),
                        Autor = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Filmes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                        IdAlbum = c.Int(nullable: false),
                        abum_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Album", t => t.abum_Id)
                .Index(t => t.abum_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Filmes", "abum_Id", "dbo.Album");
            DropIndex("dbo.Filmes", new[] { "abum_Id" });
            DropTable("dbo.Filmes");
            DropTable("dbo.Album");
        }
    }
}
