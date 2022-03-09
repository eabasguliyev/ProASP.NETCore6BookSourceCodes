using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        int hour = DateTime.Now.Hour;
        string viewModel = hour < 12 ? "Good Morning" : "Good Afternoon";
        return View("MyView", viewModel);
    }
}
