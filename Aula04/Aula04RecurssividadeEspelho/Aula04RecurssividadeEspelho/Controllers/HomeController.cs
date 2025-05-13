using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aula04RecurssividadeEspelho.Models;

namespace Aula04RecurssividadeEspelho.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet]
    public string PrintNaturalFor(int n = 1)
    {
        string retorno = string.Empty;

        int i = 10;
        while (i <= n)
        {
            retorno += $" {i} ";
            i++;
        }

        return retorno;
    }
    [HttpGet]

    public string PrintNaturalRecursion(int count)
    {
        string retorno = string.Empty;

        retorno = NaturalNumberRecursion(0, count);

        return retorno;
    }

    public string NaturalNumberRecursion(int n, int count = 1)
    {
        string ret = string.Empty;

        // Caso Base: Se o contador for maior que 10, ele para e retorna N
        if(count <= n)
            return $" {n} ";

        ret += $" {count} ";

        ret += NaturalNumberRecursion(n, count - 1);

        return ret;
    }
}
