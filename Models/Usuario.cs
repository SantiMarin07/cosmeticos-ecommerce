using System.ComponentModel.DataAnnotations;

namespace CosmeticosEcommerce.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Correo no válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string Password { get; set; }

        // Puedes agregar más campos si lo necesitas, por ejemplo:
        // public string Nombre { get; set; }
        // public string Apellido { get; set; }
    }
}