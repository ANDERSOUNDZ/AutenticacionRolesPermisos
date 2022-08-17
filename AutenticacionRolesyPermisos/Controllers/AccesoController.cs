using Microsoft.AspNetCore.Mvc;

namespace AutenticacionRolesyPermisos.Controllers
{
    public class AccesoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
