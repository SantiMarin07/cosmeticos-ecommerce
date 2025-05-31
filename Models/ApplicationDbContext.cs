using Microsoft.EntityFrameworkCore;
using CosmeticosEcommerce.Models;

namespace CosmeticosEcommerce.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
