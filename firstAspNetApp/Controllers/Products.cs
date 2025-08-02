using Microsoft.AspNetCore.Mvc;

namespace firstAspNetApp.Controllers
{
    public class Products : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        // public string Message()
        // {
        //     return "This is an important message about some product things";
        // }

        public ActionResult Message()
        {
            return View("message");
        }

        // public string Welcome(string name, int secretNumber=13)
        // {
        //     return "Hello " + name + " the secret number for today is " + secretNumber;
        // }

        public ActionResult Welcome(string name, int secretNumber=13)
        {
            ViewBag.Name = name;
            ViewBag.Secret = secretNumber;
            return View();
        }
    }
}
