using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using CosmeticosEcommerce.Models;

public class CarritoController : Controller
{
    // Carrito en memoria (se reinicia al reiniciar la aplicación).
    private static readonly List<Producto> carrito = new();

    public IActionResult Index()
    {
        return View(carrito);
    }

    public IActionResult Agregar(int id)
    {
        var producto = ProductoController.Catalogo.FirstOrDefault(p => p.Id == id);
        if (producto != null) carrito.Add(producto);
        return RedirectToAction("Index");
    }

    public IActionResult Eliminar(int id)
    {
        var producto = carrito.FirstOrDefault(p => p.Id == id);
        if (producto != null) carrito.Remove(producto);
        return RedirectToAction("Index");
    }
}
