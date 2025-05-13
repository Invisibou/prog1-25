using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aula03.Models;
using System.Security.Cryptography.X509Certificates;

namespace Aula03.Controllers;

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
    public string GetIf(int x)
    {
        /*
           Estrutura sint�tica do IF
            if(express�o booleana)
            {
                Senten�a de c�digo a ser executada caso a condi��o seja verdadeira
            }

            Caso o if tenha apenas uma linha de comando a ser executada na condicional, n�o h� necessidade do uso das chaves.
            if(express�o booleana)
                Apenas um comando
         */
        string retorno = string.Empty; //Mesma coisa que escrever string retorno = "";
        //int x = 10;

        if(x < 9)
            retorno = "x � maior que 9";

       // x = 8;
        if (x > 9)
            retorno = "x � maior que 9";
        else 
            retorno = "x � menor que 9";

       //x = 11;
        if(x == 10)
        {
            retorno = "Ora ora";
            retorno += "x � igual a 10";
        }
        else if (x == 9)
        {
            retorno = "Hmmmmmmmm";
            retorno += "x � igual a 9";
        }
        else if (x == 8)
        {
            retorno = "Bahhhhh";
            retorno += "x � igual a 8 tch�.";
        }
        else
        {
            retorno = "Sei l� que n�mero � x";
        }

            return retorno;
    }

    [HttpGet]
    public string GetSwitch(int x)
    {
        string retorno = string.Empty;

        switch(x)
        {
            case 0:
                retorno = "X � igual a zero";
                break;

            case 1:
                retorno = "X � igual a um";
                break;

            case 2:
                retorno = "X � igual a dois";
                break;

            case 3:
                retorno = "X � igual a tr�s";
                break;

            default:
                retorno = "X � um n�mero n�o previsto";
                break;
        }

        return retorno;
    }

    [HttpGet]
    public string GetFor(int x)
    {
        /*
            O comando de repeti��o for possui a seguinte sintaxe:
            for( <inicializador>; <express�o condicional>; <express�o de repeti��o>)
            {
                Comandos a serem executados
            }
            Inicializador: Elemento contador. Tradicionalmente utilizado o i = �ndice
            
            Express�o condicional: Especifica o teste a ser verificado quando o loop estiver executado o n�mero definido de intera��es;
            
            Express�o de repeti��o: Especifica a a��o a ser executada com a vari�vel contadora.
            Geralmente um acumulo ou decr�scimo (acumulador);
         */
        string retorno = string.Empty;

        for(int i = 0; i <= x; i++)
        {
            // E se eu quisesse interromper o la�o caso ele fosse maior que 5
            if (i > 50)
                break; //O comando break interrompe o la�o.

            // Caso eu deseje que o la�o siga em frente for�ando-o a continuar a execu��o
            if ((i % 2) != 0)
                continue;

            retorno += $"{i}; ";
        }

        return retorno;
    }

    [HttpGet]
    public string GetForeach(string color)
    {
        /*
           O comando foreach (para cada) � utilizado para interar por uma sequ�ncia de itens em uma cole��o e servir como uma op��o simples de repeti��o
        */
        string[] colors = { "Vermelho", "Preto", "Azul", "Amarelo", "Verde", "Branco", "Marron", "Magenta", "Cinza", "Azul-Marinho" };

        string retorno = string.Empty;

        if (colors.Contains(char.ToUpper(color[0]) + color.Substring(1)))

            retorno = "A cor escolhida � v�lida.";
        else
            retorno = "Cor escolhida inv�ldia.";

        foreach (string s in colors)
        {
            retorno += $" [{s}] ";
        }

        return retorno;
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
