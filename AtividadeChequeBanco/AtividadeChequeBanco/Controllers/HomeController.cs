//crie um novo projeto ASP.NET Core Web MVC para fazer a leitura de uma entrada de dados numérica e ser capaz de devolver à tela do usuário
//o número informado escrito por extenso.
//Lembre-se de verificar se trata-se de UNIDADE, DEZENA, CENTENA e MILHAR.

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AtividadeChequeBanco.Models;

namespace AtividadeChequeBanco.Controllers;

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
