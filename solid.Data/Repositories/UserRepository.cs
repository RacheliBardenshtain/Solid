using AutoMapper;
using Microsoft.EntityFrameworkCore;
using solid.Core.Models;
using solid.Core.Repositories;
using solid.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid.Core.Dtos;

namespace solid.Data.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public UserRepository(DataContext context,IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<IEnumerable<UserDto>> GetAsync()
        {
            var users=_context.Users.ToListAsync();
            var usersDto = _mapper.Map<IEnumerable<UserDto>>(users);
            return await Task.FromResult(usersDto);
        }


        public async Task<User> PostAsynce(UserDto user)
        {
            _context.Users.Add(_mapper.Map<User>(user));
            await  _context.SaveChangesAsync();
            return _mapper.Map<User>(user);
        }
    }
}
