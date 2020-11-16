using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using WebMatrix.WebData;

namespace VagasUnicarioca
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            WebSecurity.InitializeDatabaseConnection("VagasUnicarioca", "Usuario", "Id", "Email", true);

            if (!Roles.RoleExists("Aluno"))
            {
                Roles.CreateRole("Aluno");
            }

            if (!Roles.RoleExists("Empresa"))
            {
                Roles.CreateRole("Empresa");
            }

            if (!WebSecurity.UserExists("fabriciasales_santos@hotmail.com"))
            {
                WebSecurity.CreateUserAndAccount("fabriciasales_santos@hotmail.com", "admin", new
                {
                    Email = "fabriciasales_santos@hotmail.com",

                });
                Roles.AddUserToRole("fabriciasales_santos@hotmail.com", "Aluno");
            }
        }
    }
}
