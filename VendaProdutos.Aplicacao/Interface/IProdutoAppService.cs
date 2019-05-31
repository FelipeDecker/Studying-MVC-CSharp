using System.Collections.Generic;
using VendaProdutos.Dominio.Entidades;

namespace VendaProdutos.Aplicacao.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> FindByValue(double valor);

        IEnumerable<Produto> FindByActive(bool ativo);
    }
}
