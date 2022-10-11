using Ders1.Models;
using Microsoft.EntityFrameworkCore;

namespace Ders1.DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    }
}
