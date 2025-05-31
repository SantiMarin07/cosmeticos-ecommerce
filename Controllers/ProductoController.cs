using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CosmeticosEcommerce.Models; // ← MUY IMPORTANTE


public class ProductoController : Controller
{
    public IActionResult Index()
    {
        var productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Labial Rojo", Precio = 15.99m, ImagenUrl = "labial.jpg",Descripcion = "Una de las mejores labiales que he probado" },
            new Producto { Id = 2, Nombre = "Base de maquillaje", Precio = 29.99m, ImagenUrl = "base.jpg",Descripcion = "Una de las mejores bases que he probado" },
        };
        return View(productos);
    }
}
