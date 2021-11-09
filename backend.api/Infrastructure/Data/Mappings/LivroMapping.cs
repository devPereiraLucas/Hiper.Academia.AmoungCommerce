using backend.api.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.api.Infrastructure.Data.Mappings
{
    public class LivroMapping : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("livro");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.ImageUrl);
            builder.Property(p => p.Titulo);
            builder.Property(p => p.Autor);
            builder.Property(p => p.Nivel);
            builder.Property(p => p.Preco);
        }
    }
}
