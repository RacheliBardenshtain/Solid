using Microsoft.EntityFrameworkCore;
using solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.Core.Repositories
{
    public interface IInterviewRepository
    {
        IEnumerable<Interview> GetList();
         void Post(Interview interview);
    }
}
