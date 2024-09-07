using Microsoft.AspNetCore.Mvc;
using CalculadoraWeb.Models;

namespace CalculadoraWeb.Controllers
{
    public class CalculadoraController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculadora calculadora)
        {
            calculadora.Calcular();
            return View(calculadora);
        }
    }
}