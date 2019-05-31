using System.Data.Entity.ModelConfiguration;
using VendaProdutos.Dominio.Entidades;

namespace VendaProdutos.Infraestrutura.Dados.ConfiguracoesdeEntidade
{
    class ConfiguracoesdeItemVenda : EntityTypeConfiguration<ItemVenda>
    {
        public ConfiguracoesdeItemVenda()
        {
            HasKey(iv => iv.Id);

            Property(iv => iv.IdVenda)
                .IsRequired();

            Property(iv => iv.IdProduto)
                .IsRequired();

            Property(iv => iv.Quantidade)
                .IsRequired();

            Property(iv => iv.Valor)
                .IsRequired();

            HasRequired(iv => iv.Produto);

            //HasRequired(iv => iv.Venda);
        }
    }
}
