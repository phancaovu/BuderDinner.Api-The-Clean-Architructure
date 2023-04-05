

using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Common.Interface.Persistence
{
    public interface IUserReponsitory
    {
        User? GetUserByEmail(string email);
        void Add(User user);
    }
}
