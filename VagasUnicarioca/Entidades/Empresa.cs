using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VagasUnicarioca.Entidades
{
    public class Empresa
    {
        [Key]
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Ramo { get; set; }
        public string Descricao { get; set; }
        public string Telefone { get; set; }

        [Required]
        [Column("FK_Endereco")]
        public int? EnderecoId { get; set; }

        [ForeignKey("EnderecoId")]
        public virtual Endereco Endereco { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}