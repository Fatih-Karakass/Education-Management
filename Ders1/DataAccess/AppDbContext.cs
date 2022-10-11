using Microsoft.EntityFrameworkCore;

namespace Ders1.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    }
}
