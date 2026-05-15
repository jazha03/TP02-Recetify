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
        int edad = datos.CalcularEdad(datos.fechaNacimiento);
        string plato = datos.DeterminarPlato(datos.tipoComida, datos.presupuesto);
        double tiempo = datos.CalcularTiempo(datos.tipoComida, datos.cantComensales);
        string dificultad = datos.DeterminarDificultad(datos.presupuesto, datos.cantComensales);

      
        ViewBag.Nombre = datos.nombre;
        ViewBag.Edad = edad;
        ViewBag.Plato = plato;
        ViewBag.Tiempo = tiempo;
        ViewBag.Dificultad = dificultad;
        ViewBag.CantComensales = datos.cantComensales;
        ViewBag.Presupuesto = datos.presupuesto;
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
