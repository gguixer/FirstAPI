using FirstAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Context
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Product> Product { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {

        }

    }
}
