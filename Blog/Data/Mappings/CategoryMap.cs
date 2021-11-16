using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // Tabela
            builder.ToTable("Category");

            // Chave primária
            builder.HasKey(x => x.Id);

            // Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd() // quando item adicionado, id é gerado
                .UseIdentityColumn(); // vai gerar identity da forma correta.

            // Propriedades:
            builder.Property(x => x.Name)
                .IsRequired() // vai gerar not null
                .HasColumnName("Name") // nome da coluna
                .HasColumnType("NVARCHAR") // tipo da coluna
                .HasMaxLength(80); // tamanho máximo 

            builder.Property(x => x.Slug)
                .IsRequired() // vai gerar not null
                .HasColumnName("Slug") // nome da coluna
                .HasColumnType("VARCHAR") // tipo da coluna
                .HasMaxLength(80); // tamanho máximo 

            // Índices
            builder.HasIndex(x => x.Slug, "IX_Category_Slug")
                .IsUnique(); // garatindo que o índice seja único
        }
    }
}