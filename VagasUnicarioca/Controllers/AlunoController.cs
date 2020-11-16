using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using VagasUnicarioca.DAO;
using VagasUnicarioca.Entidades;

namespace VagasUnicarioca.Controllers
{
    public class AlunoController : Controller
    {
        private AlunoDAO alunoDAO;
        private UsuarioDAO usuarioDAO;

        public AlunoController(AlunoDAO alunoDAO, UsuarioDAO usuarioDAO)
        {
            this.alunoDAO = alunoDAO;
            this.usuarioDAO = usuarioDAO;
        }


        // GET: Aluno
        [Authorize (Roles = "Aluno")]
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                aluno.UsuarioId = Convert.ToInt32(Membership.GetUser().ProviderUserKey);
                alunoDAO.Salvar(aluno);
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Erro"] = " É necessário anexar a imagem!";
            }

            return RedirectToAction("Index");
        }

        public ActionResult CadastrarCurriculo()
        {
            return View();
        }
    }
}