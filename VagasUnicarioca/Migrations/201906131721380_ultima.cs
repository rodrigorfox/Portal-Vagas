namespace VagasUnicarioca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ultima : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sexo", "Sigla", c => c.String());
            AlterColumn("dbo.Vaga", "Bolsa", c => c.String());
            DropColumn("dbo.Usuario", "Ativo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuario", "Ativo", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Vaga", "Bolsa", c => c.Double(nullable: false));
            DropColumn("dbo.Sexo", "Sigla");
        }
    }
}
