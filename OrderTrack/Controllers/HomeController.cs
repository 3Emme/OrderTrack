using Microsoft.AspNetCore.Mvc;

namespace VendApp.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}