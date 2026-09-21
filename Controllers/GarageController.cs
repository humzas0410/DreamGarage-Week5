using DreamGarage.Models;
using Microsoft.AspNetCore.Mvc;

namespace DreamGarage.Controllers;

public class GarageController : Controller
{
    public IActionResult Index()
    {
        return View(GarageData.All);
    }
    public IActionResult Cars()
    {
        return View(GarageData.All);
    }
    public IActionResult Details(int id)
    {
        var car = GarageData.All.FirstOrDefault(c => c.Id == id);
        if (car == null)
        {
            return NotFound();
        }
        return View(car);
    }
}