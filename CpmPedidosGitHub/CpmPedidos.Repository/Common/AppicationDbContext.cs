using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CpmPedidosDomain.Entities;

namespace CpmPedidos.Repository.Common
{
    public class AppicationDbContext:DbContext
    {
        public  DbSet<Cidade> Cidades { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<CategoriaProduto> CategoriaProdutos { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<PromocaoProduto> PromocoesProdutos { get; set; }

        public DbSet<Combo> Combos { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public AppicationDbContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public AppicationDbContext(DbContextOptions<AppicationDbContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;   
        }
    }
}
