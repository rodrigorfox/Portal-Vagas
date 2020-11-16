using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VagasUnicarioca.Entidades
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }

        [Required]
        [Column("FK_Municipio")]
        public int MunicipioId { get; set; }

        [ForeignKey("MunicipioId")]
        public virtual Municipio Municipio { get; set; }

    }
}