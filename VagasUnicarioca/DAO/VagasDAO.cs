using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VagasUnicarioca.Entidades;

namespace VagasUnicarioca.DAO
{
    public class VagasDAO
    {
        private Context context;

        public VagasDAO(Context context)
        {
            this.context = context;
        }

        public void Salvar(Vaga vagas)
        {
            var user = vagas.Alunos;
            context.Vagas.Add(vagas);
            context.SaveChanges();
        }

        public IList<Vaga> Lista()
        {
            return context.Vagas.ToList();
        }

        //public IList<Vaga> ListaComFiltro(int Codigo, int Cursos, int Municipios)
        //{
        //    var query = from vaga in context.Vagas
        //                select vaga;
        //    if(Codigo > 0)
        //    {
        //        query = query.Where(x => x.Id == Codigo);
        //    }

        //    //if (Cursos > 0)
        //    //{
        //    //    query = query.Where(x => x.Cursos. == Codigo);
        //    //}

        //    //return context.Vagas.Where(x => x.Id == Codigo || x.Cursos.)
        //}
    }
}