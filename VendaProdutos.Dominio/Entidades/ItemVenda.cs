using System.Collections.Generic;

namespace VendaProdutos.Dominio.Entidades
{
    public class ItemVenda
    {
        public int Id { get; set; }

        public int IdProduto { get; set; }

        public int IdVenda { get; set; }

        public int Quantidade { get; set; }

        public double Valor { get; set; }

        public virtual Produto Produto { get; set; }

        public virtual Venda Venda { get; set; }

        public ICollection<Produto> Produtos { get; private set; }

        protected ItemVenda()
        {

        }

        public ItemVenda(int idProduto, int idVenda, int quantidade, double valor)
        {
            IdProduto = idProduto;
            IdVenda = idVenda;
            Quantidade = quantidade;
            Valor = valor;
        }
    }
}
