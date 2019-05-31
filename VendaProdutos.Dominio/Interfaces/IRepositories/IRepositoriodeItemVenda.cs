using System.Collections.Generic;
using VendaProdutos.Dominio.Entidades;

namespace VendaProdutos.Dominio.Interfaces.IRepositories
{
    public interface IRepositoriodeItemVenda : IRepositoryBase<ItemVenda>
    {
        IEnumerable<ItemVenda> FindByAmount(int quantidade);

        IEnumerable<ItemVenda> FindByValue(double valor);
    }
}
