using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_4_CSharp_With_OOP.IAuthentication
{
    internal class AuthenticationService : IAuthenticationService_i
    {
        public bool AuthenticateUser(string name, string password)
        {
            return name == "admin" && password == "admin";
            
        
            
        }

        public bool AuthorizeUser(string name, string role)
        {
            return name == "admin" && role == "adminstrator";
        }
    }
}
