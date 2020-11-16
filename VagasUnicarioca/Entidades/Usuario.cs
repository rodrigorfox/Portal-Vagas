using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VagasUnicarioca.Entidades
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }

        public virtual Aluno Alunos { get; set; }
        public virtual Empresa Empresas { get; set; }
    }
}