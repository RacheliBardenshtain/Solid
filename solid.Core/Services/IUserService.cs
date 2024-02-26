using Microsoft.EntityFrameworkCore;
using solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.Core.Services
{
    public interface IUserService
    {
        DbSet<User> GetAll();
        void Post(User user);
    }
}
