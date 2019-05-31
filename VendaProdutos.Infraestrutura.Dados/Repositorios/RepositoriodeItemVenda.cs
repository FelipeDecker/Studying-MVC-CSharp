using System.Collections.Generic;
using System.Linq;
using VendaProdutos.Dominio.Entidades;
using VendaProdutos.Dominio.Interfaces.IRepositories;


namespace VendaProdutos.Infraestrutura.Dados.Repositorios
{
    public class RepositoriodeItemVenda : RepositorioBase<ItemVenda>, IRepositoriodeItemVenda
    {
        public IEnumerable<ItemVenda> FindByAmount(int quantidade)
        {
            return DbContext.ItemVEndas
                .Where(v => v.Quantidade == quantidade);
        }

        public IEnumerable<ItemVenda> FindByValue(double valor)
        {
            return DbContext.ItemVEndas
                .Where(v => v.Valor == valor);
        }
    }
}
