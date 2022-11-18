using Microsoft.EntityFrameworkCore;
using WebApiDemo1.Models;

namespace WebApiDemo1.Infrastructure
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
