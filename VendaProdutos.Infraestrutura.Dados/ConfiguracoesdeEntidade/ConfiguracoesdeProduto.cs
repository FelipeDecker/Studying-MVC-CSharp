using System.Data.Entity.ModelConfiguration;
using VendaProdutos.Dominio.Entidades;

namespace VendaProdutos.Infraestrutura.Dados.ConfiguracoesdeEntidade
{
    public class ConfiguracoesdeProduto : EntityTypeConfiguration<Produto>
    {
        public ConfiguracoesdeProduto()
        {
            HasKey(p => p.Id);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(1000);

            Property(p => p.Valor)
                .IsRequired();

            HasMany(v => v.ItemVenda)
                .WithMany();
        }
    }
}
