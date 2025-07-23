using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bellossomIT.Models;

namespace bellossomIT.Controllers;

public class FlowerController : Controller
{
    private readonly ILogger<FlowerController> _logger;

    public FlowerController(ILogger<FlowerController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
