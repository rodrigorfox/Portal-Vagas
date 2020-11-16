using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using VagasUnicarioca.DAO;

namespace VagasUnicarioca.Controllers
{
    //[Authorize(Roles ="Aluno")]
    public class PainelInternoController : Controller
    {
        private UsuarioDAO usuarioDAO;
        private AlunoDAO alunoDAO;

        public PainelInternoController(UsuarioDAO usuarioDAO, AlunoDAO alunoDAO)
        {
            this.usuarioDAO = usuarioDAO;
            this.alunoDAO = alunoDAO;
        }

        public ActionResult Empresa(int Id = 1)
        {

            return View();
        }
        public ActionResult Estudante(int Id = 1)
        {
            //var user = Convert.ToInt32(Membership.GetUser().ProviderUserKey);
            var aluno = alunoDAO.ObterAluno(Id);
            return View(aluno);
        }
        public ActionResult CadastroAluno()
        {
            return View();
        }

        public ActionResult CadastroEmpresa()
        {
            return View();
        }

        public ActionResult BuscarCandidato()
        {
            return View();
        }       
    }
}