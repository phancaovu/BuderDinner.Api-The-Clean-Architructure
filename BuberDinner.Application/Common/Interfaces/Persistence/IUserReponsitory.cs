

using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Common.Interface.Persistence
{
    public interface IUserReponsitory
    {
        User? GetUserByEmail(string username);
        void Add(User user);
    }
}
