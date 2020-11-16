using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VagasUnicarioca.DAO;

namespace VagasUnicarioca.Controllers
{
    //[Authorize(Roles ="Aluno")]
    public class HomeController : Controller
    {
        private UsuarioDAO usuarioDAO;

        public HomeController(UsuarioDAO usuarioDAO)
        {
            this.usuarioDAO = usuarioDAO;
        }

        public ActionResult Index()
        {
            // return View();
            var vagas = usuarioDAO.Lista();
            return View(vagas);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}