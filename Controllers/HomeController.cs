using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LaunchPad.Models;

namespace LaunchPad.Controllers;

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
    
    public IActionResult Testing()
    {
        string connectionString;
        SqlConnection sqlConnection;
        
        var conn = Server=tcp:chuckslaunchpadserver.database.windows.net,1433;Initial Catalog=LaunchPadDB;Persist Security Info=False;User ID=crandles;Password=Valerie55!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
        conn.open();
        
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
