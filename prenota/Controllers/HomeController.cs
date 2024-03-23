using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using prenota.Models;


namespace prenota.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private static List<Utente> Utenti = new List<Utente>();

    

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;

    }

    public IActionResult Index()
    {
        return View();
    }

     public IActionResult Prenota()
    {
        return View();
    }

    [HttpPost]
     public IActionResult Prenotato(Utente u)
    {
        string? nomeUtente = HttpContext.Session.GetString("NomeUtente");
        if(string.IsNullOrEmpty(nomeUtente))
            return Redirect("\\home\\index");

      /*  database db = new();
        db.Utenti().Add(u);
        db.SaveChanges();*/
        HttpContext.Session.SetString("NomeUtente", "Maurizio Conti");
        return View(u);
       
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
//codice da mettere in prenotazione!
// string? nomeUtente = HttpContext.Session.GetString("NomeUtente");
// if (string.IsNullOrEmpty(nomeUtente))
//      return Redirect("\\home\\index");

