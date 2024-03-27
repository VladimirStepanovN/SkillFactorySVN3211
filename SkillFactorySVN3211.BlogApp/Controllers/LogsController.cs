using Microsoft.AspNetCore.Mvc;
using SkillFactorySVN3211.DAL.Repositories;

namespace SkillFactorySVN3211.BlogApp.Controllers
{
    public class LogsController : Controller
    {
        private readonly ILoggingRepository _repo;

        public LogsController(ILoggingRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var requests = await _repo.GetRequests();
            return View(requests);
        }
    }
}
