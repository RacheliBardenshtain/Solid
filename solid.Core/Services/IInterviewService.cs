using Microsoft.EntityFrameworkCore;
using solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.Core.Services
{
    public interface IInterviewService
    {
        IEnumerable<Interview> GetAll();
        void Post(Interview interview);
    }
}
