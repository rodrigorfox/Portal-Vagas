using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VagasUnicarioca.Entidades
{
    public class Vaga
    {
        [Key]
        public int  Id { get; set; }
        public string Descricao { get; set; }
        public string Titulo { get; set; }
        public DateTime? DataPublicacao { get; set; }       
        public DateTime? DataExpiracao { get; set; }
        public string Bolsa { get; set; }
        public string Diferenciais { get; set; }
        public string Horario { get; set; }
        public string Local { get; set; }

        [Required]
        [Column("FK_Empresas")]
        public int EmpresaId { get; set; }

        [ForeignKey("EmpresaId")]
        public virtual Empresa Empresas { get; set; }

        [Required]
        [Column("FK_Municipio")]
        public int MunicipioId { get; set; }

        [ForeignKey("MunicipioId")]
        public virtual Municipio Municipio { get; set; }

        public virtual ICollection<Aluno> Alunos { get; set; }
        public virtual ICollection<Deficiencia> Deficiencias { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }
    }
}