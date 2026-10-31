
using BasicApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars => Set<Car>();
    }
}
