# Cosméticos E-commerce

Tienda en línea de cosméticos hecha con **ASP.NET Core MVC** y **MySQL**, con un módulo de **análisis facial por cámara** que detecta el rostro del cliente y le sugiere productos de cuidado de la piel.

Proyecto académico de la asignatura Programación 4.

![.NET](https://img.shields.io/badge/.NET-10-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=csharp&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-4479A1?style=flat-square&logo=mysql&logoColor=white)
![Entity Framework](https://img.shields.io/badge/EF%20Core-8-512BD4?style=flat-square)
![Emgu CV](https://img.shields.io/badge/Emgu%20CV-OpenCV-5C3EE8?style=flat-square&logo=opencv&logoColor=white)

## Funcionalidades

| Módulo | Qué hace |
|---|---|
| **Inicio** | Página de bienvenida con secciones de cuidado, hidratación y maquillaje. |
| **Catálogo** | Lista de productos con imagen, descripción y precio. |
| **Carrito** | Agregar productos desde el catálogo y quitarlos del carrito. |
| **Registro** | Registro de usuarios guardado en MySQL con Entity Framework Core. |
| **Análisis facial** | Toma una foto con la cámara del navegador, detecta el rostro con un clasificador Haar Cascade de OpenCV (Emgu CV) y muestra una recomendación de productos. |

## Tecnologías

- ASP.NET Core MVC (.NET 10) con vistas Razor
- Entity Framework Core 8 + Pomelo MySQL
- MySQL
- Emgu CV (OpenCV para .NET) para la detección de rostros
- HTML, CSS y JavaScript

## Estructura

```
Controllers/   Home, Producto, Carrito, Account (registro) y Face (análisis facial)
Models/        Producto, Usuario y ApplicationDbContext
Views/         Vistas Razor de cada módulo
Classifiers/   haarcascade_frontalface_default.xml (detección de rostros)
wwwroot/       CSS, JavaScript e imágenes
```

## Cómo correrlo

**Requisitos:** .NET 10 SDK, MySQL y Windows (Emgu CV usa el runtime de Windows).

1. Crea la base de datos `ecommerce_cosmeticos` en MySQL.
2. En `appsettings.json`, cambia `TU_PASSWORD` por la contraseña de tu MySQL:
   ```json
   "DefaultConnection": "Server=localhost;Database=ecommerce_cosmeticos;Uid=root;Pwd=TU_PASSWORD;"
   ```
3. Ejecuta:
   ```bash
   dotnet restore
   dotnet run
   ```
4. Abre la URL que muestra la consola.

## Limitaciones conocidas

- El catálogo y el carrito usan datos de ejemplo en memoria; todavía no leen productos de la base de datos.
- La recomendación del análisis facial usa una edad simulada. El siguiente paso sería estimar la edad o el tipo de piel con un modelo real.

---

Hecho por **Santiago Marín** · [Portafolio](https://portafolio-react-eosin.vercel.app/) · [GitHub](https://github.com/SantiMarin07)
