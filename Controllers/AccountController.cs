using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string UserName, string Password)
        {
            return View();
        }
        [HttpPost]
        public ActionResult ForgetPassword(string btnSubmit)
        {        
            if (btnSubmit == "Forget Password")
            {
                return RedirectToAction("forget", "Account");
            }
            return RedirectToAction("Login", "Account");
        }
        public ActionResult forget()
        {
            return View();
        }
    }
}