using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CosmeticosEcommerce.Models;

public class ProductoController : Controller
{
    // Catálogo de ejemplo mientras los productos no se leen de MySQL.
    public static readonly List<Producto> Catalogo = new()
    {
        new Producto { Id = 1, Nombre = "Labial Rojo", Precio = 15.99m, ImagenUrl = "labial.jpg", Descripcion = "Labial de larga duración con acabado cremoso." },
        new Producto { Id = 2, Nombre = "Base de maquillaje", Precio = 29.99m, ImagenUrl = "base.jpg", Descripcion = "Base de cobertura media para un acabado natural." },
    };

    public IActionResult Index()
    {
        return View(Catalogo);
    }
}
