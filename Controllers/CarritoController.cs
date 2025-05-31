using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using CosmeticosEcommerce.Models; // ← MUY IMPORTANTE


public class CarritoController : Controller
{
    private static List<Producto> carrito = new List<Producto>();

    public IActionResult Index()
    {
        return View(carrito);
    }

    public IActionResult Agregar(int id)
    {
        var producto = new Producto { Id = id, Nombre = "Producto Ejemplo", Precio = 20.99m, ImagenUrl = "base.jpg",Descripcion = "Descripcion del producto" };
        carrito.Add(producto);
        return RedirectToAction("Index");
    }

    public IActionResult Eliminar(int id)
    {
        var producto = carrito.FirstOrDefault(p => p.Id == id);
        if (producto != null) carrito.Remove(producto);
        return RedirectToAction("Index");
    }
}
