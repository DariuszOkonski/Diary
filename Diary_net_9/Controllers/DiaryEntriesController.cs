using Microsoft.AspNetCore.Mvc;

namespace Diary_net_9.Controllers
{
    public class DiaryEntriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
