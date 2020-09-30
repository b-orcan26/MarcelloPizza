using Business.Interfaces;
using DAL.Interfaces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : Manager<User> , IUserService
    {
        private readonly IUserRepository _repository;
        public UserManager(IUserRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public User LoginUser(string Username, string Password)
        {
            return _repository.LoginUser(Username, Password);
        }
    }
}
