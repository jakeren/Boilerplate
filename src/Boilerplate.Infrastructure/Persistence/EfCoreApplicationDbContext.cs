using Microsoft.EntityFrameworkCore;

namespace Boilerplate.Infrastructure.Persistence
{
    public class EfCoreApplicationDbContext : DbContext
    {
        public EfCoreApplicationDbContext(DbContextOptions<EfCoreApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("boilerplate");
        }
    }
}