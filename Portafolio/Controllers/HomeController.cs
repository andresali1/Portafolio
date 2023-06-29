using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Get: Index
        public IActionResult Index()
        {
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>
            {
                new Proyecto
                {
                    Titulo = "Mercado Liebre",
                    Descripcion = "E-Commerce emulando página real",
                    Link = "https://github.com/andresali1/MercadoL",
                    ImagenUrl = "/imagenes/logo-mercado-liebre.png"
                },
                new Proyecto
                {
                    Titulo = "Fast Food",
                    Descripcion = "E-Commerce realizado en NodeJs",
                    Link = "https://github.com/andresali1/fastFood.git",
                    ImagenUrl = "/imagenes/Logo-Fast-Food.png"
                },
                new Proyecto
                {
                    Titulo = "Shopping Cart",
                    Descripcion = "Aplicación MVC realizada con .Net Framework",
                    Link = "https://github.com/andresali1/ShoppingCartMVC",
                    ImagenUrl = "/imagenes/Shopping-cart-logo.jpg"
                },
                new Proyecto
                {
                    Titulo = "Running App",
                    Descripcion = "Aplicación simulando red social de Corredores",
                    Link = "https://github.com/andresali1/RunningAppNetCore",
                    ImagenUrl = "/imagenes/Runner-logo.jpg"
                }
            };
        }

        public IActionResult Privacy()
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