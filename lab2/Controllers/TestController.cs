using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class TestController : Controller
    {
        public IActionResult TestSession()
        {
            HttpContext.Session.SetString("name", "remonda");
            HttpContext.Session.SetInt32("id", 1);

            return Content($"Name: {HttpContext.Session.GetString("name")}, ID: {HttpContext.Session.GetInt32("id")}");

        }
    }
}
