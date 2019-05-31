using System.Collections.Generic;
using VendaProdutos.Dominio.Entidades;

namespace VendaProdutos.Dominio.Interfaces.IRepositories
{
    public interface IRepositoriodeProduto : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> FindByValue(double valor);

        IEnumerable<Produto> FindByActive(bool ativo);
    }
}
