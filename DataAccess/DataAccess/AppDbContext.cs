using Dershane.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Dershane.DataAccsess.DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Lesson> Lesson { get; set; }
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
