using BuberDinner.Application.Common.Interfaces.Authentication;

namespace BuberDinner.Application.Services.Authentiaction
{
    public class AuthenticationService : IAuthenticationService
    {
        public readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public AuthentiactionResult Register(string email, string password, string lastname, string firstname)
        {
            // check if user already exits

            // create user (generate unique ID)

            // create jwt token

            Guid userId = Guid.NewGuid();
            var token = _jwtTokenGenerator.GenerateToken( userId, lastname, firstname);
            
            return new AuthentiactionResult(
                userId,
                lastname,
                firstname,
                email,
                token); ;
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
