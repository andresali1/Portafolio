using Portafolio.Interfaces;
using Portafolio.Models;

namespace Portafolio.Services
{
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
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
    }
}
