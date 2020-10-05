using Fruits.Infra.ModelConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Fruits.Infra.Context
{
    public class FruitsDbContext : DbContext
    {
        public FruitsDbContext(DbContextOptions<FruitsDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Inject all map classes of EF
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TreeConfiguration).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
