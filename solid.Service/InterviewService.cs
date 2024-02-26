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
    public class InterviewService:IInterviewService
    {
        private readonly IInterviewRepository _interviewRepository;

        public InterviewService(IInterviewRepository interviewRepository)
        {
            _interviewRepository =interviewRepository ;
        }
        public IEnumerable<Interview> GetAll()
        {
            return _interviewRepository.GetList();
        }

        public void Post(Interview interview)
        {
            _interviewRepository.Post(interview);
        }
    }
}
