using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TestOnline.Areas.Admin.Models.Login;

namespace TestOnline.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Admin/Login/

        public ActionResult Index(LoginModel model)
        {
            if (Membership.ValidateUser(model.username, model.password))
            {
                FormsAuthentication.SetAuthCookie(model.username, model.remember);
                return RedirectToRoute("AdminHome");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult SignIn(LoginModel model)
        {
            //return RedirectToAction("Index", "Admin/HomeAdmin");
            if (Membership.ValidateUser(model.username, model.password))
            {
                FormsAuthentication.SetAuthCookie(model.username, model.remember);
                return RedirectToRoute("AdminHome");
            }
            else
            {
                return RedirectToRoute("Admin_default");
            }
            
        }

    }
}
