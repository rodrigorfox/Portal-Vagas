using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VagasUnicarioca.Entidades;

namespace VagasUnicarioca.DAO
{
    public class MunicipioDAO
    {
        private Context context;

        public MunicipioDAO(Context context)
        {
            this.context = context;
        }

        public IList<Municipio> Lista()
        {
            return context.Municipios.ToList();
        }
    }
}