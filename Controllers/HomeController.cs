using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DiadiaApp.Models;

namespace DiadiaApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var challenges = new List<Challenge>
        {
            new Challenge
            {
                Id = 1,
                Title = "Compra cualquier producto Manty en Diadia y duplica tus puntos",
                ImageUrl = "https://images.unsplash.com/photo-1608797178974-15b35a64ede9",
                HasX2Badge = true,
                Points = 2,
                ExpiryText = "Vence en 15 días",
                Status = ChallengeStatus.New,
                IsIconCard = false
            },
            new Challenge
            {
                Id = 2,
                Title = "Compra estos 5 productos en Diadia y gana 640 puntos adicionales",
                ImageUrl = "https://images.unsplash.com/photo-1607349913338-fca6f7fc42d0",
                Points = 640,
                ExpiryText = "Vence en 15 días",
                Progress = 0,
                Total = 5,
                Status = ChallengeStatus.New,
                IsIconCard = false
            },
            new Challenge
            {
                Id = 3,
                Title = "¡Ingresa tu fecha de cumpleaños y gana!",
                Points = 60,
                ExpiryText = "Vence en 15 días",
                Progress = 0,
                Total = 1,
                Status = ChallengeStatus.New,
                IsIconCard = true,
                IconClass = "fa-gift",
                IconTitle = "+60"
            },
            new Challenge
            {
                Id = 4,
                Title = "Compra en diadia entre las 6pm y 11pm y gana puntos adicionales",
                Points = 320,
                ExpiryText = "Vence en 6 días",
                Progress = 1,
                Total = 1,
                Status = ChallengeStatus.Completed,
                IsIconCard = true,
                IconClass = "",
                IconTitle = "diadia"
            }
        };

        ViewBag.AvailablePoints = 2654;
        return View(challenges);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
