using Microsoft.EntityFrameworkCore;
using EstadoCuentaApi.Models;

namespace EstadoCuentaApi.Data   // 👈 IMPORTANTE
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<EstadoCuentaView> EstadoCuentas { get; set; }
        public DbSet<TbCliente> Clientes { get; set; }
        public DbSet<ClienteXInmueble> ClientesXInmueble { get; set; }
        public DbSet<Inmueble> Inmuebles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EstadoCuentaView>().HasNoKey().ToTable("v_eecc");
            modelBuilder.Entity<TbCliente>().ToTable("tb_clientes");
            modelBuilder.Entity<ClienteXInmueble>().ToTable("tb_clientesxinmueble");
            modelBuilder.Entity<Inmueble>().ToTable("tb_inmuebles");
        }
    }
}
