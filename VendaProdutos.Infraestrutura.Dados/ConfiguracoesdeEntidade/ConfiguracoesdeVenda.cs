using System.Data.Entity.ModelConfiguration;
using VendaProdutos.Dominio.Entidades;

namespace VendaProdutos.Infraestrutura.Dados.ConfiguracoesdeEntidade
{
    class ConfiguracoesdeVenda : EntityTypeConfiguration<Venda>
    {
        public ConfiguracoesdeVenda()
        {
            HasKey(v => v.Id);

            Property(v => v.Data)
                .IsRequired();

            HasMany(v => v.ItemVenda)
                .WithMany();
        }
    }
}
