using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Services.Authentiaction
{
    public record AuthentiactionResult(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token
    );
}
