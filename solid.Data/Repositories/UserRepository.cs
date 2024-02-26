using Microsoft.EntityFrameworkCore;
using solid.Core.Models;
using solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.Data.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }
        public DbSet<User> GetList()
        {
            return _context.Users;
        }
        public void Post(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
