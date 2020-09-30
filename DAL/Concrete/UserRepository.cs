using DAL.EFCoreContext;
using DAL.Interfaces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Concrete
{
    public class UserRepository : Repository<User> , IUserRepository
    {
        public UserRepository(MyDbContext _db) : base(_db)
        {

        }

        public User LoginUser(string Username, string Password)
        {
            var user = base.db.Users.Where(i => i.Username == Username && i.Password == Password).FirstOrDefault();
            return user;
        }
    }
}
