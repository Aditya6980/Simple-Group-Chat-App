using Microsoft.AspNetCore.Mvc;

namespace Simple_Group_Chat_App.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
