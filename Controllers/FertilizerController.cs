using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bellossomIT.Models;

namespace bellossomIT.Controllers;

public class FertilizerController : Controller
{
    private readonly ILogger<FertilizerController> _logger;

    public FertilizerController(ILogger<FertilizerController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
