using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VagasUnicarioca.Entidades
{
    public class Aluno
    {
        [Key]
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Naturalidade { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string NmPai { get; set; }
        public string NmMae { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public string Matricula { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string Periodo { get; set; }
        
        [Column("FK_Sexo")]
        public int? SexoId { get; set; }

        [ForeignKey("SexoId")]
        public virtual Sexo Sexo { get; set; }


        [Column("FK_Endereco")]
        public int? EnderecoId { get; set; }

        [ForeignKey("EnderecoId")]
        public virtual Endereco Endereco { get; set; }

        public virtual ICollection<Curso> Cursos { get; set; }
        public virtual ICollection<Habilidade> Habilidades { get; set; }
        public virtual ICollection<Vaga> Vagas { get; set; }
        public virtual ICollection<Deficiencia> Deficiencias { get; set; }
        public virtual ICollection<Idioma> Idiomas { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}