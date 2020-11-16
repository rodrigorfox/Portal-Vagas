namespace VagasUnicarioca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CamposFaltantes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aluno", "Periodo", c => c.String());
            AddColumn("dbo.Vaga", "DataExpiracao", c => c.DateTime());
            DropColumn("dbo.Vaga", "DataExpiração");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vaga", "DataExpiração", c => c.DateTime());
            DropColumn("dbo.Vaga", "DataExpiracao");
            DropColumn("dbo.Aluno", "Periodo");
        }
    }
}
