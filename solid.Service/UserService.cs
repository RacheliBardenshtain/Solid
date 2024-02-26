using Microsoft.EntityFrameworkCore;
using solid.Core.Models;
using solid.Core.Repositories;
using solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.Service
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public DbSet<User> GetAll()
        {
            return _userRepository.GetList();
        }

        public void Post(User user)
        {
            _userRepository.Post(user);
        }
    }
}
