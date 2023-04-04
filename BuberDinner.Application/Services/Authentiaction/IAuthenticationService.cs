using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Services.Authentiaction
{
    public interface IAuthenticationService
    {
        AuthentiactionResult Register(string email, string password, string lastname, string firstname);

        AuthentiactionResult Login(string email, string password);
    }
}
