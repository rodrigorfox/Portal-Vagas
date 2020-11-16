using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VagasUnicarioca.Entidades
{
    public class Municipio
    {
        public int Id { get; set; }
        [StringLength(60)]
        public string Titulo { get; set; }

        [Required]
        [Column("FK_UF")]
        public int UFId { get; set; }

        [ForeignKey("UFId")]
        public virtual UF UF { get; set; }
    }
}