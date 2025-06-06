﻿
using System.Diagnostics;

namespace Restaurants.API.Middlewares
{
    public class RequestTimeLogginMiddleware(ILogger<RequestTimeLogginMiddleware> logger) : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var stopwatch = Stopwatch.StartNew();   
            await next.Invoke(context);
            stopwatch.Stop();

            if(stopwatch.ElapsedMilliseconds / 1000 > 4)
            {
                logger.LogInformation("Request [{verb}] at {path} took {Time} ms",
                context.Request.Method,
                context.Request.Path,
                stopwatch.ElapsedMilliseconds);
            }
        }
    }
}
