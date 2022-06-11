using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinimalAPI.PostgreSQL.Models;

namespace MinimalAPI.PostgreSQL.Data.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> modelBuilder)
        {
            modelBuilder.HasKey(p => p.Id);

            modelBuilder.Property(p => p.Nome)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

            modelBuilder.Property(p => p.Documento)
                    .IsRequired()
                    .HasColumnType("varchar(14)");

            modelBuilder.ToTable("Clientes");
        }
    }
}
