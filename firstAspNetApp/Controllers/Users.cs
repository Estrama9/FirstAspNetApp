using Microsoft.AspNetCore.Mvc;

namespace firstAspNetApp.Controllers
{
    public class Users : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

    }
}
