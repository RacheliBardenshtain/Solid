﻿using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace solid
{
    public class ShabbatMiddleware
    {

        private readonly RequestDelegate _next;
        private readonly ILogger<ShabbatMiddleware> _logger;

        public ShabbatMiddleware(RequestDelegate next, ILogger<ShabbatMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (DateTime.Today.DayOfWeek==DayOfWeek.Saturday)
            {
                var problemDetails = new ProblemDetails
                {
                    Status = (int)HttpStatusCode.BadRequest,
                    Title = "Today is Shabbat",
                    Detail = "We are not working today",
                    Type = "https://solid/error",
                    Instance = context.Request.Path
                };

                context.Response.ContentType = "application/problem+json";

                context.Response.StatusCode = problemDetails.Status ?? (int)HttpStatusCode.InternalServerError;
                await context.Response.WriteAsJsonAsync(problemDetails);

            }
            else
            {
                var requestSeq = Guid.NewGuid().ToString();
                _logger.LogInformation($"Request Starts {requestSeq}");
                context.Items.Add("RequestSequence", requestSeq);
                await _next(context);
                _logger.LogInformation($"Request Ends {requestSeq}");
            }          
        }
    }
}
