using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebApplication2.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int ID = 1)
        {
            ViewData["name"] = name;
            ViewData["id"] = ID;
            return View();
        }
    }
}