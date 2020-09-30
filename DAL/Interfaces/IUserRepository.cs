using Entities.Concrete;

namespace DAL.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User LoginUser(string Username , string Password);
    }
}
