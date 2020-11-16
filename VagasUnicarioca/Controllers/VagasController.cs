using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VagasUnicarioca.DAO;

namespace VagasUnicarioca.Controllers
{
    public class VagasController : Controller
    {
        private VagasDAO vagasDAO;
        private CursoDAO cursoDAO;
        private MunicipioDAO municipioDAO;

        public VagasController(VagasDAO vagasDAO, CursoDAO cursoDAO, MunicipioDAO municipioDAO)
        {
            this.vagasDAO = vagasDAO;
            this.cursoDAO = cursoDAO;
            this.municipioDAO = municipioDAO;

           
        }
        // GET: Vagas
        public ActionResult Index()
        {
            // var cursos = vagasDAO.Lista();
            ViewBag.ListaCusrsos = cursoDAO.Lista();
            ViewBag.ListaMunicipio = municipioDAO.Lista();
            return View();
        }

        public ActionResult Search()
        {

            return View();
        }
        public ActionResult DetalheVaga()
        {

            return View();
        }
        public ActionResult EmpresaVaga()
        {

            return View();
        }

        public ActionResult CadastroVaga()
        {

            return View();
        }

        //[HttpPost]
        //public ActionResult BuscarVagas( int Codigo, int Cursos, int Municipios)
        //{
        //    vagasDAO.ListaComFiltro(Codigo, Cursos, Municipios);
        //}
    }
}