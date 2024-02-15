using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeApp
{
    public class Signin
    {
        public string Authenticate(string userName,string password)
        {
            string msg;
            if((string.IsNullOrEmpty(userName)) || string.IsNullOrEmpty(password))
            {
                msg = "User name and password requried";
            }
            else
            {
                if((userName == "admin") && (password == "admin@1234"))
                {
                    msg = "Authentication Pass";
                }
                else
                {
                    msg = "Authentication Fail";
                }
                   
            }
            return msg;
        }
    }
}
