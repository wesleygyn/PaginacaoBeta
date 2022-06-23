using Microsoft.EntityFrameworkCore;
using PaginacaoBetaAPI.Models;

namespace PaginacaoBetaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
