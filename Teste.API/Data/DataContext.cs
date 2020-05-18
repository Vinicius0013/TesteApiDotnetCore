using Microsoft.EntityFrameworkCore;
using Teste.API.Models;

namespace Teste.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}