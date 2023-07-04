using Microsoft.AspNetCore.Mvc;
using Portafolio.Interfaces;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositorioProyectos _repositorioProyectos;

        public HomeController(IRepositorioProyectos repositorioProyectos)
        {
            _repositorioProyectos = repositorioProyectos;
        }

        //Get: Index
        public IActionResult Index()
        {
            var proyectos = _repositorioProyectos.ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };

            return View(modelo);
        }

        //Get: Proyectos
        public IActionResult Proyectos()
        {
            var proyectos = _repositorioProyectos.ObtenerProyectos();

            return View(proyectos);
        }

        //Get: Contacto
        [HttpGet]
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(ContactoViewModel contactoViewModel)
        {
            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}