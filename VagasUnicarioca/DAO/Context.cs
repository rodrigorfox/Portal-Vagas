using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using VagasUnicarioca.Entidades;

namespace VagasUnicarioca.DAO
{
    public class Context : DbContext
    {
        public Context() : base("VagasUnicarioca") { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<CursoExtra> CursosExtra { get; set; }
        public DbSet<Deficiencia> Deficiencias { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Experiencia> Experiencias { get; set; }
        public DbSet<Habilidade> Habilidades { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Sexo> Sexo { get; set; }
        public DbSet<UF> UF { get; set; }
        public DbSet<Vaga> Vagas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }





        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);


            // Configure StudentId as FK for StudentAddress
            modelBuilder.Entity<Usuario>()
                        .HasRequired(s => s.Alunos)
                        .WithRequiredPrincipal(ad => ad.Usuario);

            // Configure StudentId as FK for StudentAddress
            modelBuilder.Entity<Usuario>()
                        .HasRequired(s => s.Empresas)
                        .WithRequiredPrincipal(ad => ad.Usuario);



            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConve‌​ntion>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        
    }
}