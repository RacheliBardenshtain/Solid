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
    public class JobRepository : IJobRepository
    {

        private readonly DataContext _context;
        public JobRepository(DataContext context)
        {
            _context = context;
        }
        public DbSet<Job> GetList()
        {
            return _context.Jobs;
        }
        public void Post(Job job)
        {
            _context.Jobs.Add(job);
            _context.SaveChanges();
        }
    }
}


