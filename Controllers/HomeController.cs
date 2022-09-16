using Microsoft.AspNetCore.Mvc;
using trabajo1.Models;

namespace trabajo1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MiPerfil(PerfilViewModel perfil)
        {
            return View(perfil);
        }
    }
}
