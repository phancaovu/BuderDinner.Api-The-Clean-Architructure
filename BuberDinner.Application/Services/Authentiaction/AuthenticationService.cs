using BuberDinner.Application.Common.Interface.Persistence;
using BuberDinner.Application.Common.Interfaces.Authentication;
using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Services.Authentiaction
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserReponsitory _userReponsitory;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserReponsitory userReponsitory)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userReponsitory = userReponsitory;
        }

        public AuthentiactionResult Register(string email, string password, string lastname, string firstname)
        {
            // 1 check if user already exits
            if(_userReponsitory.GetUserByEmail(email) is not null) {
                throw new Exception("USER đã tồn tại")
            }
            //2 create user (generate unique ID)
            var user = new User
            {
                Email = email,
                FirstName = firstname,
                LastName = lastname,
                Password = password
            };
            _userReponsitory.Add(user);
            //3 create jwt token

            var token = _jwtTokenGenerator.GenerateToken( user.Id, lastname, firstname);
            
            return new AuthentiactionResult(
                user.Id,
                lastname,
                firstname,
                email,
                token); ;
        }

        public AuthentiactionResult Login(string email, string password)
        {
            // 1. validate user  exists
            if(_userReponsitory.GetUserByEmail(email) is not User user)
            {
                throw new Exception("email ko co trong danh sach");
            }
            // 2. validate the password is correct]
            if(user.Password != password) {
                throw new Exception("Invalid password")
             }
            // 3. Create Jwt token
            var token = _jwtTokenGenerator.GenerateToken(user.Id, user.FirstName, user.LastName);
            return new AuthentiactionResult(
                user.Id,
                user.FirstName,
                user.LastName,
                email,
                token) ;
        }

      
    }
}
