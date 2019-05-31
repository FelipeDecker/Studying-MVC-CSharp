using System.Collections.Generic;
using System.Linq;
using VendaProdutos.Dominio.Entidades;
using VendaProdutos.Dominio.Interfaces.IRepositories;

namespace VendaProdutos.Infraestrutura.Dados.Repositorios
{
    public class RepositoriodeProduto : RepositorioBase<Produto>, IRepositoriodeProduto
    {
        public IEnumerable<Produto> FindByActive(bool ativo)
        {
            return DbContext.Produtos
                .Where(p => p.Ativo == ativo);
        }

        public IEnumerable<Produto> FindByValue(double valor)
        {
            return DbContext.Produtos
                .Where(p => p.Valor == valor);
        }
    }
}
