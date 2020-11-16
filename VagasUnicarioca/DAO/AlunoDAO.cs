using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VagasUnicarioca.Entidades;

namespace VagasUnicarioca.DAO
{
    public class AlunoDAO
    {
        private Context context;

        public AlunoDAO(Context context)
        {
            this.context = context;
        }

        public void Salvar( Aluno aluno)
        {
            context.Alunos.Add(aluno);
            context.SaveChanges();
        }

        public IList<Usuario> Lista()
        {
            return context.Usuarios.ToList();
        }

        internal object ObterAluno(int Id)
        {
            return context.Alunos.Find(Id);
        }
    }
}