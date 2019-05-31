using System.Collections.Generic;
using VendaProdutos.Dominio.Entidades;
using VendaProdutos.Dominio.Interfaces.IRepositories;
using VendaProdutos.Dominio.Interfaces.Services;

namespace VendaProdutos.Dominio.Servicos
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private IRepositoriodeProduto _produtoRepository;

        public ProdutoService(IRepositoriodeProduto produtoRepository) : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> FindByActive(bool ativo)
        {
            return _produtoRepository.FindByActive(ativo);
        }

        public IEnumerable<Produto> FindByValue(double valor)
        {
            return _produtoRepository.FindByValue(valor);
        }
    }
}
