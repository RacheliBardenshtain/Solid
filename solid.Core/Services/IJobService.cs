﻿using Microsoft.EntityFrameworkCore;
using solid.Core.Dtos;
using solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.Core.Services
{
    public interface IJobService
    {
        Task<IEnumerable<JobDto>> GetList();
        Task<Job> PostAsynce(JobDto job);
    }
}
