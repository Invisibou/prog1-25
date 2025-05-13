using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aula5.Models;
using Modelo;

namespace Aula5.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Customer c1 = new Customer();
        c1.Name = "Frodo";
        c1.ObjectCount++;
        Customer.InstanceCount++; //Acrescentou em 1

        var c2 = new Customer();
        c2.Name = "Galadriel";
        c2.ObjectCount++;
        Customer.InstanceCount++; //é um valor independente dos objetos, ele pertence a classe, como tinha acrescentado 1, agora é 2.
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
