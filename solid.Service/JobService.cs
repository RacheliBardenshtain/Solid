using Microsoft.EntityFrameworkCore;
using solid.Core.Dtos;
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
    public class JobService:IJobService
    {
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public IEnumerable<JobDto> GetAll()
        {
            return _jobRepository.GetList();
        }

        public  void Post(JobDto job)
        {
            _jobRepository.Post(job);
        }
    }
}
