using EcommerceProduct.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EcommerceProduct.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
