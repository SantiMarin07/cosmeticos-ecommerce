using Microsoft.AspNetCore.Mvc;
using CosmeticosEcommerce.Models; // Asegúrate de tener el namespace correcto
using CosmeticosEcommerce.Data;   // Asegúrate de tener el namespace correcto

namespace CosmeticosEcommerce.Controllers
{
    [Route("Cuenta")]
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("Register")]
        public IActionResult Register(Usuario model)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(model);
                _context.SaveChanges();
                ViewBag.Message = "¡Registro exitoso!";
                return View();
            }
            ViewBag.Message = "Error en el registro";
            return View(model);
        }
    }
}