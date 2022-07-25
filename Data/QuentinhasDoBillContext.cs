using Microsoft.EntityFrameworkCore;
using QuentinhasDoBill.Models;

namespace QuentinhasDoBill.Data
{
    public class QuentinhasDoBillContext : DbContext
    {
        public QuentinhasDoBillContext() : base()
        {
        }
        public QuentinhasDoBillContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Quentinha>? Quentinhas { get; set; }
        public DbSet<Tipo>? Tipos { get; set; }
        public DbSet<Carrinho>? Carrinho { get; set; }
        public DbSet<Pedido>? Pedidos { get; set; }
        public DbSet<ItemPedido>? Itens_pedido { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=quentinhas_do_bill;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quentinha>()
                .HasKey(e => e.Id)
                .HasName("PrimaryKey_QuentinhaId");

            modelBuilder.Entity<Tipo>()
                .HasKey(e => e.Id)
                .HasName("PrimaryKey_TipoId");

            modelBuilder.Entity<Carrinho>()
                .HasKey(e => e.Id)
                .HasName("PrimaryKey_CarrinhoId");

            modelBuilder.Entity<Pedido>()
                .HasKey(e => e.Id)
                .HasName("PrimaryKey_PedidoId");

            modelBuilder.Entity<ItemPedido>()
                .HasKey(e => e.Id)
                .HasName("PrimaryKey_ItemPedidoId");
        }
    }
}
