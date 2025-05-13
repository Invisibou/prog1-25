using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AtividadeDiasDaSemana.Models;

namespace AtividadeDiasDaSemana.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public string GetDiaSemana(int x)
    {
        string[] diasSemana = new string[7] { "Domingo", "Segunda", "Terça", "Quarto", "Quinta", "Sexto", "Sabádo" };

        if (x > 0)
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
