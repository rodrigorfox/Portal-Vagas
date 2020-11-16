using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using VagasUnicarioca.DAO;
using VagasUnicarioca.Entidades;
using VagasUnicarioca.Models;
using WebMatrix.WebData;

namespace VagasUnicarioca.Controllers
{
    public class AccountController : Controller
    {
        private UsuarioDAO usuarioDAO;
        private AlunoDAO alunoDAO;

        public AccountController(UsuarioDAO usuarioDAO, AlunoDAO alunoDAO)
        {
            this.usuarioDAO = usuarioDAO;
            this.alunoDAO = alunoDAO;
        }

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginAluno()
        {
            if (WebSecurity.IsAuthenticated)
            {
                var UserAuth = Membership.GetUser().ToString();
                Roles.GetRolesForUser(UserAuth).Contains("Aluno");

                return RedirectToAction("Estudante", "PainelInterno");
            }
            else
            {
                return View();
            }
        }

        public ActionResult LoginEmpresa()
        {
            if (WebSecurity.IsAuthenticated)
            {
                var UserAuth = Membership.GetUser().ToString();
                Roles.GetRolesForUser(UserAuth).Contains("Empresa");

                return RedirectToAction("Estudante", "PainelInterno");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        /*public ActionResult Autentica(String login, String senha)
        {
            if (WebSecurity.IsAuthenticated && Roles.GetRolesForUser(login).Contains("Aluno"))
            {             
                return RedirectToAction("Estudante", "PainelInterno");
            }
            else if ((WebSecurity.IsAuthenticated && Roles.GetRolesForUser(login).Contains("Empresa")))
            {
                return RedirectToAction("Empresa", "PainelInterno");

            }
            else if (WebSecurity.Login(login, senha))
            {
                if (Roles.GetRolesForUser(login).Contains("Aluno"))
                {
                    return RedirectToAction("Estudante", "PainelInterno");
                }
                else
                {
                    return RedirectToAction("Empresa", "PainelInterno");
                }
            }




            return RedirectToAction("Index", "Home");
        }*/

        public ActionResult Adiciona(UsuarioModel model, Aluno aluno, bool Ealuno = true)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (Ealuno == true)
                    {
                        WebSecurity.CreateUserAndAccount(model.Email, model.Senha,
                       new { model.Email });
                        Roles.AddUserToRole(model.Email, "Aluno");

                        //WebSecurity.Login(model.Email, Membership.password)

                        WebSecurity.Login(model.Email, model.Senha);
                        aluno.UsuarioId = WebSecurity.GetUserId(model.Email);
                        aluno.Nome = model.Alunos.Nome;
                        aluno.Matricula = model.Alunos.Matricula;
                        aluno.NmPai = model.Alunos.NmPai;
                        aluno.NmMae = model.Alunos.NmMae;

                        alunoDAO.Salvar(aluno);



                        //usuarioDAO.Salvar(usuario);

                        //aluno.UsuarioId = model.Id;
                        // alunoDAO.Salvar(usuario);
                        return RedirectToAction("Cadastro", "Aluno");
                    }
                    else
                    {
                        WebSecurity.CreateUserAndAccount(model.Email, model.Senha,
                       new { Email = model.Email });
                        Roles.AddUserToRole(model.Email, "Empresa");
                        return RedirectToAction("Index", "ListaEventos");
                    }

                }
                catch (MembershipCreateUserException e)
                {
                    ModelState.AddModelError("usuario.Invalido", e.Message);
                    return View("Create", model);
                }
            }
            else
            {
                return View("Create", model);
            }
        }

        //[Authorize]
        public ActionResult Logout()
        {
            WebSecurity.Logout();
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}