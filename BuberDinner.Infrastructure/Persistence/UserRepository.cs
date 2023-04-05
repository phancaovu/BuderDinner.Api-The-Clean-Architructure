using BuberDinner.Application.Common.Interface.Persistence;
using BuberDinner.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Infrastructure.Persistence
{
    // đặt bireebs static tĩnh gọi addscope trong service
    public class UserRepository : IUserReponsitory
    {
        private static readonly List<User> _users = new(); 
        public void Add(User user)
        {
            _users.Add(user);
        }

        public User? GetUserByEmail(string email)
        {
            return _users.SingleOrDefault(x => x.Email == email);
        }
    }
}
