﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using VagasUnicarioca.Entidades;

namespace VagasUnicarioca.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string NmPai { get; set; }
        public string NmMae { get; set; }

        public virtual Aluno Alunos { get; set; }
        public virtual Empresa Empresas { get; set; }

    }
}