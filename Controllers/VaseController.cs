using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bellossomIT.Models;

namespace bellossomIT.Controllers;

public class VaseController : Controller
{
    private readonly ILogger<VaseController> _logger;

    public VaseController(ILogger<VaseController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
