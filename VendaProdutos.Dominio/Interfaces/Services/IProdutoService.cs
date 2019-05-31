using System.Collections.Generic;
using VendaProdutos.Dominio.Entidades;

namespace VendaProdutos.Dominio.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> FindByValue(double valor);

        IEnumerable<Produto> FindByActive(bool ativo);
    }
}
