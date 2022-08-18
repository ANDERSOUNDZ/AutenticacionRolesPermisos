using Microsoft.AspNetCore.Mvc;
using AutenticacionRolesyPermisos.Models;
using AutenticacionRolesyPermisos.Data;

namespace AutenticacionRolesyPermisos.Controllers
{
    public class AccesoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Usuario _usuario)
        {
            DA_Logica _da_usuario = new DA_Logica();
            var usuario = _da_usuario.ValidarUsuario(_usuario.Correo, _usuario.Clave );

            if (usuario != null) {
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Salir()
        {
            return RedirectToAction("Index", "Acceso");
        }
    }
}
