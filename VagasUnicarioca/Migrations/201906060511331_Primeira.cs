namespace VagasUnicarioca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Primeira : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aluno",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false),
                        Nome = c.String(),
                        Cpf = c.String(),
                        Naturalidade = c.String(),
                        DataNascimento = c.DateTime(),
                        NmPai = c.String(),
                        NmMae = c.String(),
                        Celular = c.String(),
                        Telefone = c.String(),
                        Matricula = c.String(),
                        DataCadastro = c.DateTime(),
                        FK_Sexo = c.Int(),
                        FK_Endereco = c.Int(),
                    })
                .PrimaryKey(t => t.UsuarioId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId)
                .ForeignKey("dbo.Endereco", t => t.FK_Endereco)
                .ForeignKey("dbo.Sexo", t => t.FK_Sexo)
                .Index(t => t.UsuarioId)
                .Index(t => t.FK_Sexo)
                .Index(t => t.FK_Endereco);
            
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vaga",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Titulo = c.String(),
                        DataPublicacao = c.DateTime(),
                        DataExpiração = c.DateTime(),
                        Bolsa = c.String(),
                        Diferenciais = c.String(),
                        Horario = c.String(),
                        Local = c.String(),
                        FK_Empresas = c.Int(nullable: false),
                        FK_Municipio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empresa", t => t.FK_Empresas)
                .ForeignKey("dbo.Municipio", t => t.FK_Municipio)
                .Index(t => t.FK_Empresas)
                .Index(t => t.FK_Municipio);
            
            CreateTable(
                "dbo.Deficiencia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false),
                        NomeFantasia = c.String(),
                        RazaoSocial = c.String(),
                        Cnpj = c.String(),
                        Ramo = c.String(),
                        Descricao = c.String(),
                        Telefone = c.String(),
                        FK_Endereco = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioId)
                .ForeignKey("dbo.Endereco", t => t.FK_Endereco)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId)
                .Index(t => t.UsuarioId)
                .Index(t => t.FK_Endereco);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CEP = c.String(),
                        Rua = c.String(),
                        Complemento = c.String(),
                        Numero = c.String(),
                        Bairro = c.String(),
                        FK_Municipio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Municipio", t => t.FK_Municipio)
                .Index(t => t.FK_Municipio);
            
            CreateTable(
                "dbo.Municipio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(maxLength: 60),
                        FK_UF = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UF", t => t.FK_UF)
                .Index(t => t.FK_UF);
            
            CreateTable(
                "dbo.UF",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Habilidade",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Idioma",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sexo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Sigla = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CursoExtra",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Descricao = c.String(),
                        CargaHoraria = c.String(),
                        FK_Alunos = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aluno", t => t.FK_Alunos)
                .Index(t => t.FK_Alunos);
            
            CreateTable(
                "dbo.Experiencia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Empresa = c.String(),
                        DataInicio = c.DateTime(),
                        DataFim = c.DateTime(),
                        Atividades = c.String(),
                        FK_Alunos = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aluno", t => t.FK_Alunos)
                .Index(t => t.FK_Alunos);
            
            CreateTable(
                "dbo.CursoAluno",
                c => new
                    {
                        Curso_Id = c.Int(nullable: false),
                        Aluno_UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Curso_Id, t.Aluno_UsuarioId })
                .ForeignKey("dbo.Curso", t => t.Curso_Id)
                .ForeignKey("dbo.Aluno", t => t.Aluno_UsuarioId)
                .Index(t => t.Curso_Id)
                .Index(t => t.Aluno_UsuarioId);
            
            CreateTable(
                "dbo.VagaAluno",
                c => new
                    {
                        Vaga_Id = c.Int(nullable: false),
                        Aluno_UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Vaga_Id, t.Aluno_UsuarioId })
                .ForeignKey("dbo.Vaga", t => t.Vaga_Id)
                .ForeignKey("dbo.Aluno", t => t.Aluno_UsuarioId)
                .Index(t => t.Vaga_Id)
                .Index(t => t.Aluno_UsuarioId);
            
            CreateTable(
                "dbo.VagaCurso",
                c => new
                    {
                        Vaga_Id = c.Int(nullable: false),
                        Curso_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Vaga_Id, t.Curso_Id })
                .ForeignKey("dbo.Vaga", t => t.Vaga_Id)
                .ForeignKey("dbo.Curso", t => t.Curso_Id)
                .Index(t => t.Vaga_Id)
                .Index(t => t.Curso_Id);
            
            CreateTable(
                "dbo.DeficienciaAluno",
                c => new
                    {
                        Deficiencia_Id = c.Int(nullable: false),
                        Aluno_UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Deficiencia_Id, t.Aluno_UsuarioId })
                .ForeignKey("dbo.Deficiencia", t => t.Deficiencia_Id)
                .ForeignKey("dbo.Aluno", t => t.Aluno_UsuarioId)
                .Index(t => t.Deficiencia_Id)
                .Index(t => t.Aluno_UsuarioId);
            
            CreateTable(
                "dbo.DeficienciaVaga",
                c => new
                    {
                        Deficiencia_Id = c.Int(nullable: false),
                        Vaga_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Deficiencia_Id, t.Vaga_Id })
                .ForeignKey("dbo.Deficiencia", t => t.Deficiencia_Id)
                .ForeignKey("dbo.Vaga", t => t.Vaga_Id)
                .Index(t => t.Deficiencia_Id)
                .Index(t => t.Vaga_Id);
            
            CreateTable(
                "dbo.HabilidadeAluno",
                c => new
                    {
                        Habilidade_Id = c.Int(nullable: false),
                        Aluno_UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Habilidade_Id, t.Aluno_UsuarioId })
                .ForeignKey("dbo.Habilidade", t => t.Habilidade_Id)
                .ForeignKey("dbo.Aluno", t => t.Aluno_UsuarioId)
                .Index(t => t.Habilidade_Id)
                .Index(t => t.Aluno_UsuarioId);
            
            CreateTable(
                "dbo.IdiomaAluno",
                c => new
                    {
                        Idioma_Id = c.Int(nullable: false),
                        Aluno_UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Idioma_Id, t.Aluno_UsuarioId })
                .ForeignKey("dbo.Idioma", t => t.Idioma_Id)
                .ForeignKey("dbo.Aluno", t => t.Aluno_UsuarioId)
                .Index(t => t.Idioma_Id)
                .Index(t => t.Aluno_UsuarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Experiencia", "FK_Alunos", "dbo.Aluno");
            DropForeignKey("dbo.CursoExtra", "FK_Alunos", "dbo.Aluno");
            DropForeignKey("dbo.Aluno", "FK_Sexo", "dbo.Sexo");
            DropForeignKey("dbo.IdiomaAluno", "Aluno_UsuarioId", "dbo.Aluno");
            DropForeignKey("dbo.IdiomaAluno", "Idioma_Id", "dbo.Idioma");
            DropForeignKey("dbo.HabilidadeAluno", "Aluno_UsuarioId", "dbo.Aluno");
            DropForeignKey("dbo.HabilidadeAluno", "Habilidade_Id", "dbo.Habilidade");
            DropForeignKey("dbo.Aluno", "FK_Endereco", "dbo.Endereco");
            DropForeignKey("dbo.Vaga", "FK_Municipio", "dbo.Municipio");
            DropForeignKey("dbo.Vaga", "FK_Empresas", "dbo.Empresa");
            DropForeignKey("dbo.Empresa", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.Aluno", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.Empresa", "FK_Endereco", "dbo.Endereco");
            DropForeignKey("dbo.Endereco", "FK_Municipio", "dbo.Municipio");
            DropForeignKey("dbo.Municipio", "FK_UF", "dbo.UF");
            DropForeignKey("dbo.DeficienciaVaga", "Vaga_Id", "dbo.Vaga");
            DropForeignKey("dbo.DeficienciaVaga", "Deficiencia_Id", "dbo.Deficiencia");
            DropForeignKey("dbo.DeficienciaAluno", "Aluno_UsuarioId", "dbo.Aluno");
            DropForeignKey("dbo.DeficienciaAluno", "Deficiencia_Id", "dbo.Deficiencia");
            DropForeignKey("dbo.VagaCurso", "Curso_Id", "dbo.Curso");
            DropForeignKey("dbo.VagaCurso", "Vaga_Id", "dbo.Vaga");
            DropForeignKey("dbo.VagaAluno", "Aluno_UsuarioId", "dbo.Aluno");
            DropForeignKey("dbo.VagaAluno", "Vaga_Id", "dbo.Vaga");
            DropForeignKey("dbo.CursoAluno", "Aluno_UsuarioId", "dbo.Aluno");
            DropForeignKey("dbo.CursoAluno", "Curso_Id", "dbo.Curso");
            DropIndex("dbo.IdiomaAluno", new[] { "Aluno_UsuarioId" });
            DropIndex("dbo.IdiomaAluno", new[] { "Idioma_Id" });
            DropIndex("dbo.HabilidadeAluno", new[] { "Aluno_UsuarioId" });
            DropIndex("dbo.HabilidadeAluno", new[] { "Habilidade_Id" });
            DropIndex("dbo.DeficienciaVaga", new[] { "Vaga_Id" });
            DropIndex("dbo.DeficienciaVaga", new[] { "Deficiencia_Id" });
            DropIndex("dbo.DeficienciaAluno", new[] { "Aluno_UsuarioId" });
            DropIndex("dbo.DeficienciaAluno", new[] { "Deficiencia_Id" });
            DropIndex("dbo.VagaCurso", new[] { "Curso_Id" });
            DropIndex("dbo.VagaCurso", new[] { "Vaga_Id" });
            DropIndex("dbo.VagaAluno", new[] { "Aluno_UsuarioId" });
            DropIndex("dbo.VagaAluno", new[] { "Vaga_Id" });
            DropIndex("dbo.CursoAluno", new[] { "Aluno_UsuarioId" });
            DropIndex("dbo.CursoAluno", new[] { "Curso_Id" });
            DropIndex("dbo.Experiencia", new[] { "FK_Alunos" });
            DropIndex("dbo.CursoExtra", new[] { "FK_Alunos" });
            DropIndex("dbo.Municipio", new[] { "FK_UF" });
            DropIndex("dbo.Endereco", new[] { "FK_Municipio" });
            DropIndex("dbo.Empresa", new[] { "FK_Endereco" });
            DropIndex("dbo.Empresa", new[] { "UsuarioId" });
            DropIndex("dbo.Vaga", new[] { "FK_Municipio" });
            DropIndex("dbo.Vaga", new[] { "FK_Empresas" });
            DropIndex("dbo.Aluno", new[] { "FK_Endereco" });
            DropIndex("dbo.Aluno", new[] { "FK_Sexo" });
            DropIndex("dbo.Aluno", new[] { "UsuarioId" });
            DropTable("dbo.IdiomaAluno");
            DropTable("dbo.HabilidadeAluno");
            DropTable("dbo.DeficienciaVaga");
            DropTable("dbo.DeficienciaAluno");
            DropTable("dbo.VagaCurso");
            DropTable("dbo.VagaAluno");
            DropTable("dbo.CursoAluno");
            DropTable("dbo.Experiencia");
            DropTable("dbo.CursoExtra");
            DropTable("dbo.Sexo");
            DropTable("dbo.Idioma");
            DropTable("dbo.Habilidade");
            DropTable("dbo.Usuario");
            DropTable("dbo.UF");
            DropTable("dbo.Municipio");
            DropTable("dbo.Endereco");
            DropTable("dbo.Empresa");
            DropTable("dbo.Deficiencia");
            DropTable("dbo.Vaga");
            DropTable("dbo.Curso");
            DropTable("dbo.Aluno");
        }
    }
}
