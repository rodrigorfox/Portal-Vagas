using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VagasUnicarioca.Entidades
{
    public class Sexo
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Sigla { get; set; }
    }
}