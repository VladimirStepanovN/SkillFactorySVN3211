using SkillFactorySVN3211.DAL.Entities;
using SkillFactorySVN3211.DAL.Repositories;

namespace SkillFactorySVN3211.BlogApp.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private ILoggingRepository _loggingRepository;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ILoggingRepository loggingRepository)
        {
            _loggingRepository = loggingRepository;

            Request request = new()
            {
                Url = $"http://{context.Request.Host.Value + context.Request.Path}",
                Date = DateTime.Now,
                Id = Guid.NewGuid()
            };

            await _loggingRepository.AddRequest(request);
            await _next.Invoke(context);
        }
    }
}
