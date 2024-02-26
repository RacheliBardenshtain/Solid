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
    public class InterviewRepository : IInterviewRepository
    {

        private readonly DataContext _context;
        public InterviewRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Interview> GetList()
        {
            return _context.Interviews.Include(i=>i.User);
            
        }

        public void Post(Interview interview)
        {
            _context.Interviews.Add(interview);
            _context.SaveChanges();
        }
    }
}


