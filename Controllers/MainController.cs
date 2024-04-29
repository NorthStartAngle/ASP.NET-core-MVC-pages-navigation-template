using Microsoft.AspNetCore.Mvc;

namespace proMVC.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NavPage(int pg)
        {
            ViewData["page"] = pg;
            return View("index");
        }

    
        public string Result()
        {
            return "Result is 3. OK!";
        }

        [HttpPost]
        public async Task<IActionResult> Result(int? ret)
        {
            return View();
        }
    }
}
