using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VagasUnicarioca.Entidades
{
    public class Habilidade
    {
        [Key]
        public int Id { get; set; }
        public int Titulo { get; set; }

        public virtual ICollection<Aluno> Alunos { get; set; }
    }
}