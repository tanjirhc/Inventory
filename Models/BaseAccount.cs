using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
    public class BaseAccount
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool VerifyLogin()
        {
            if (baseAccount.UserName == "Tanjir" && baseAccount.Password == "1234")
            {
                Session["User"] = "Tanjir";
                LoginMsg = "Login Success";
                return RedirectToAction("Dashboard", "Home");
            }
            return false;
        }
    }
}