using Ejercicio1.Models;
using Ejercicio1.Models.DAL;
using Ejercicio1.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DateTime horaActual = DateTime.Now;
            String mensaje = "";
            if (horaActual.Hour < 12)
            {
                mensaje = "Buenos días";
            }
            else if (horaActual.Hour >= 12 && horaActual.Hour <20)
            {
                mensaje = "Buenas tardes";
            }
            else if (horaActual.Hour >= 20)
            {
                mensaje = "Buenas noches";
            }
            ViewData["Mensaje"] = mensaje;
            ViewBag.horaActual = DateTime.Now.ToLongDateString();
            clsPersona persona= new clsPersona();
            persona.Nombre = "Alejandro";
            persona.Apellido = "Sosa";
            return View(persona);
        }
        public IActionResult EditarPersona()
        {
            return View();
        }
        public IActionResult listaPersona()
        {
            try
            {
                return View(listadoPersonas.listaPersonas());
            }catch (Exception ex)
            {
                return View("Error");
            }
            
        }
        
    }
}