using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VagasUnicarioca.Entidades
{
    public class CursoExtra
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string CargaHoraria { get; set; }

        [Required]
        [Column("FK_Alunos")]
        public int AlunoId { get; set; }

        [ForeignKey("AlunoId")]
        public virtual Aluno Aluno { get; set; }
    }
}