using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using PWII_Lab05_Valverde_Zamora_MVC_B.Models;

namespace PWII_Lab05_Valverde_Zamora_MVC_B.Controllers
{
    public class UsuarioController : Controller
    {
        private static List<ClsUsuario> ListaUsuarios = new List<ClsUsuario>();

        public ActionResult Index()
        {
            return View(ListaUsuarios); 
        }

        [HttpPost]
        public ActionResult GuardarContacto(ClsUsuario ObjUsuario)
        {
            if (string.IsNullOrEmpty(ObjUsuario.Nombre) ||
                string.IsNullOrEmpty(ObjUsuario.Correo) ||
                ObjUsuario.Numero == 0 ||
                ObjUsuario.Numero2 == 0)
            {
                ViewBag.MensajeError = "Todos los campos deben ser obligatorios.";
                return View("Index", ListaUsuarios);
            }

            
            if (!Regex.IsMatch(ObjUsuario.Correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                ViewBag.MensajeError = "Ingrese un correo válido.";
                return View("Index", ListaUsuarios);
            }

            
            ListaUsuarios.Add(ObjUsuario);
            return RedirectToAction("Index");
        }
    }
}
