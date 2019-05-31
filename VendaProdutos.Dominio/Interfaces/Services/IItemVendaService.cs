using System.Collections.Generic;
using VendaProdutos.Dominio.Entidades;

namespace VendaProdutos.Dominio.Interfaces.Services
{
    public interface IItemVendaService : IServiceBase<ItemVenda>
    {
        IEnumerable<ItemVenda> FindByAmount(int quantidade);

        IEnumerable<ItemVenda> FindByValue(double valor);
    }
}
