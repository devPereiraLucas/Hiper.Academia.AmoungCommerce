using backend.api.Infrastructure.Data.Mappings;
using backend.api.Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.api.Infrastructure.Data
{
    public class LivroDbContext : DbContext
    {
        public LivroDbContext(DbContextOptions<LivroDbContext> options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LivroMapping());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Livro> Livro { get; set; }
    }
}
