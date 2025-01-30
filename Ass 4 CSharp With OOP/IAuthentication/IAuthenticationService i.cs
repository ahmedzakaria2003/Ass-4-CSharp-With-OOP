using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_4_CSharp_With_OOP.IAuthentication
{
 public interface IAuthenticationService_i
    {
            bool AuthenticateUser(string name ,  string password);
         bool  AuthorizeUser(string name, string role );

    }
}
