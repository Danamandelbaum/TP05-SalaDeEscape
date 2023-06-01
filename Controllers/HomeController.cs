using Microsoft.AspNetCore.Mvc;

namespace TP05SalaDeEscape.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
