using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace MISP
{
    public class LoginModel
    {
        public string Phone { get; set; }
        public string Password { get; set; }
    }

    public class RegisterModel
    {
        public string Phone { get; set; }
        public string Password { get; set; }

        public string Address { get; set; }

        public string Name { get; set; }

    }
}