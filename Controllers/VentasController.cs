using Microsoft.AspNetCore.Mvc;
using appgamestore.Models;

namespace appgamestore.Controllers
{
    public class VentasController:Controller
    {
         public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewData["Message"] = "Venta registrada";
            return View("index");
        }
        
    }
}