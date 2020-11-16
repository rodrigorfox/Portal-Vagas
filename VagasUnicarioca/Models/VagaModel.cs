using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VagasUnicarioca.Entidades;

namespace VagasUnicarioca.Models
{
    public class VagaModel
    {
        public string Id { get; set; }      
        public string Titulo { get; set; }
        
        public List<Curso> ListadeCursos { get; set; }
        //public Curso Cursos { get; set; }
        public Municipio Municipios { get; set; }
    }
}