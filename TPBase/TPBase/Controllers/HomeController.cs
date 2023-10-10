using Microsoft.AspNetCore.Mvc;

namespace TP-10.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Series = BD.MostrarInfoSerie();
        return View();
    }
}
