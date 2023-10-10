using Microsoft.AspNetCore.Mvc;

namespace TP-10.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Series = BD.MostrarSeries();
        return View();
    }

    //-------------------------------------------

    public IActionResult Series(int id)
    {
        ViewBag.Serie = BD.MostrarInfoSerie();
        return ViewBag.Series;
    }


    public IActionResult Actor(int id)
    {
        ViewBag.Actores = BD.MostrarInfoActor();
        return ViewBag.Actores;
    }

    public IActionResult Temporada(int id)
    {
        ViewBag.Temporadas = BD.MostrarInfoTemporada();
        return ViewBag.Temporadas;
    }
    
}
