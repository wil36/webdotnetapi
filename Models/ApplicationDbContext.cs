using Microsoft.EntityFrameworkCore;

namespace AspWebApi.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Products> Products { get; set; }

        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options)
        {

        }   
    }
}
