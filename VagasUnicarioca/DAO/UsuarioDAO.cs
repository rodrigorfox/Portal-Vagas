using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VagasUnicarioca.Entidades;

namespace VagasUnicarioca.DAO
{
    public class UsuarioDAO
    {
        private Context context;

        public UsuarioDAO(Context context)
        {
            this.context = context;
        }

        public void Salvar(Usuario usuario)
        {
            var user = usuario.Alunos;
            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }

        public IList<Usuario> Lista()
        {
            return context.Usuarios.ToList();
        }
    }
}