using Microsoft.EntityFrameworkCore;
using MinimalAPI.PostgreSQL.Data.Mapping;
using MinimalAPI.PostgreSQL.Models;

namespace MinimalAPI.PostgreSQL.Data.Context
{
    public class MinimalPostgreContext : DbContext
    {
        public MinimalPostgreContext(DbContextOptions<MinimalPostgreContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
