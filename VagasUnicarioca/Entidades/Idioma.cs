using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VagasUnicarioca.Entidades
{
    public class Idioma
    {
        [Key]
        public int Id { get; set; }
        public string Titulo  { get; set; }

        public virtual ICollection<Aluno> Alunos { get; set; }
    }
}