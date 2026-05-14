using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP02.Models;

namespace TP02.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult GenerarSugerencia(SugeridorReceta datos)
    {
        int edad = datos.CalcularEdad(datos.FechaNacimiento);
        string plato = datos.DeterminarPlato(datos.TipoComida, datos.Presupuesto);
        double tiempo = datos.CalcularTiempo(datos.TipoComida, datos.CantComensales);
        string dificultad = datos.DeterminarDificultad(datos.Presupuesto, datos.CantComensales);

      
        ViewBag.Nombre = datos.Nombre;
        ViewBag.Edad = edad;
        ViewBag.Plato = plato;
        ViewBag.Tiempo = tiempo;
        ViewBag.Dificultad = dificultad;
        ViewBag.CantComensales = datos.CantComensales;
        ViewBag.Presupuesto = datos.Presupuesto;
        return View("Resultado");
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
