using System.Collections.Generic;
using VendaProdutos.Dominio.Entidades;

namespace VendaProdutos.Aplicacao.Interface
{
    public interface IItemVendaAppService : IAppServiceBase<ItemVenda>
    {
        IEnumerable<ItemVenda> FindByAmount(int quantidade);

        IEnumerable<ItemVenda> FindByValue(double valor);
    }
}
