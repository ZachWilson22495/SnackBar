using Microsoft.AspNetCore.Mvc;

namespace SnackBar.Controllers
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