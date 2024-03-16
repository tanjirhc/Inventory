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
            return false;
        }
    }
}