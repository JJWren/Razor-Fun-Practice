using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RazorFunPractice.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/")]
        public ViewResult Index()
        {
            // This will serve //Views/Home/Index.cshtml
            return View();
        }
    }
}