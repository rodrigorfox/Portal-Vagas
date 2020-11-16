using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VagasUnicarioca.Entidades;

namespace VagasUnicarioca.DAO
{
    public class CursoDAO
    {
        private Context context;

        public CursoDAO(Context context)
        {
            this.context = context;
        }

        public IList<Curso> Lista()
        {
            return context.Cursos.ToList();
        }
    }
}