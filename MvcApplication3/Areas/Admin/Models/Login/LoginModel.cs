using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestOnline.Areas.Admin.Models.Login
{
    public class LoginModel
    {
        public LoginModel()
        {
            this.username = "";
            this.password = "";
            this.remember = false;
        }
        public string username { get; set; }
        public string password { get; set; }
        public bool remember { get; set; }
    }
}