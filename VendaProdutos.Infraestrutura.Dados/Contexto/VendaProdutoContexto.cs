using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using VendaProdutos.Dominio.Entidades;
using VendaProdutos.Infraestrutura.Dados.ConfiguracoesdeEntidade;

namespace VendaProdutos.Infraestrutura.Dados.Contexto
{
    public class VendaProdutoContexto : DbContext
    {
        public VendaProdutoContexto()
            : base("VendaProduto")
        {

        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ItemVenda> ItemVEndas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(256));

            modelBuilder.Configurations.Add(new ConfiguracoesdeProduto());
            modelBuilder.Configurations.Add(new ConfiguracoesdeVenda());
            modelBuilder.Configurations.Add(new ConfiguracoesdeItemVenda());

        }
    }
}
