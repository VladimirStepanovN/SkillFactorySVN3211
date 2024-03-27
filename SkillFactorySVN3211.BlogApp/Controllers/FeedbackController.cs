using Microsoft.AspNetCore.Mvc;
using SkillFactorySVN3211.BlogApp.Models;
using System.Diagnostics;

namespace SkillFactorySVN3211.BlogApp.Controllers
{
    public class FeedbackController : Controller
    {

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Feedback feedback)
        {
            return StatusCode(200, $"{feedback.From}, спасибо за отзыв!");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
