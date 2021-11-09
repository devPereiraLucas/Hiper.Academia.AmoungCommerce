using backend.api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace backend.api.Configurations
{
    public class DbFactoryDbContext : IDesignTimeDbContextFactory<LivroDbContext>
    {
        public LivroDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LivroDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AmoungAPI;Trusted_Connection=true;");
            LivroDbContext contexto = new LivroDbContext(optionsBuilder.Options);

            return contexto;
        }
    }
}
