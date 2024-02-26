﻿using Microsoft.AspNetCore.Mvc;
using solid.Core.Models;
using solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace solid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewController : ControllerBase
    {
        private readonly IInterviewService _interviewService;

        public InterviewController(IInterviewService interviewService)
        {
            _interviewService = interviewService;
        }


        // GET: api/<InterviewController>
        [HttpGet]
        public IEnumerable<Interview> Get()
        {
            return _interviewService.GetAll();
        }
        //// GET: api/<InterviewController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<InterviewController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<InterviewController>
        [HttpPost]
        public void Post(Interview interview)
        {
           _interviewService.Post(interview);
        }

        //// PUT api/<InterviewController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<InterviewController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
