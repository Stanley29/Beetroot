using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UnitTesting.Models;

namespace UnitTesting.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Message"] = "Hello!";
        return View("Index");
    }
}