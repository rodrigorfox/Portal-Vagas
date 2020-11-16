using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VagasUnicarioca.Entidades
{
    public class Experiencia
    {
        [Key]
        public int Id { get; set; }
        public string Empresa { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string Atividades { get; set; }
        [Required]
        [Column("FK_Alunos")]
        public int AlunoId { get; set; }

        [ForeignKey("AlunoId")]
        public virtual Aluno Aluno { get; set; }
    }
}