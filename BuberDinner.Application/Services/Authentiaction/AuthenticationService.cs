using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Services.Authentiaction
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthentiactionResult Register(string email, string password, string lastname, string firstname)
        {
            return new AuthentiactionResult(
                Guid.NewGuid(),
                lastname,
                firstname,
                email,
                "token"); ;
        }

        public AuthentiactionResult Login(string email, string password)
        {
            return new AuthentiactionResult(
                Guid.NewGuid(),
                "lastname",
                "firstname",
                email,
                "token"); ;
        }
    }
}
