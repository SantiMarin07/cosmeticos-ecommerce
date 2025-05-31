using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using System.Drawing;
using System.IO;
using Emgu.CV;
using Emgu.CV.Structure;

namespace CosmeticosEcommerce.Controllers
{
    public class FaceController : Controller
    {
        [HttpGet]
        public IActionResult Camara()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AnalizarDesdeCamara(string imageData)
        {
            // Extraer y decodificar la imagen base64
            var base64Data = Regex.Match(imageData, @"data:image/(?<type>.+?),(?<data>.+)").Groups["data"].Value;
            byte[] imageBytes = Convert.FromBase64String(base64Data);

            // Guardar imagen temporalmente
            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/temp.jpg");
            System.IO.File.WriteAllBytes(imagePath, imageBytes);

            // Procesar con Emgu.CV
            var image = new Image<Bgr, byte>(imagePath);
            var gray = image.Convert<Gray, byte>();
            var faceCascade = new CascadeClassifier(Path.Combine(Directory.GetCurrentDirectory(), "Classifiers/haarcascade_frontalface_default.xml"));
            var faces = faceCascade.DetectMultiScale(gray, 1.1, 10, Size.Empty);

            foreach (var face in faces)
            {
                image.Draw(face, new Bgr(Color.Red), 2);
            }

            // Guardar imagen analizada
            string outputImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/resultado.jpg");
            image.Save(outputImagePath);

            ViewBag.ImagePath = "/images/resultado.jpg";
            ViewBag.TotalFaces = faces.Length;
            ViewBag.Sugerencia = SugerirProducto(25); // Simular edad estimada

            return View("Resultado");
        }

        private string SugerirProducto(int edad)
        {
            if (edad < 20) return "Crema hidratante ligera y protector solar.";
            if (edad < 30) return "Sérum antioxidante y crema con vitamina C.";
            if (edad < 40) return "Crema antiarrugas y contorno de ojos.";
            return "Tratamiento reafirmante y crema con retinol.";
        }
    }
}
