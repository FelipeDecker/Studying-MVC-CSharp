using System.Collections.Generic;
using VendaProdutos.Aplicacao.Interface;
using VendaProdutos.Dominio.Entidades;
using VendaProdutos.Dominio.Interfaces.Services;

namespace VendaProdutos.Aplicacao
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService) : base(produtoService)
        {
            _produtoService = produtoService;
        }
        
        public IEnumerable<Produto> FindByActive(bool ativo)
        {
            return _produtoService.FindByActive(ativo);
        }

        public IEnumerable<Produto> FindByValue(double valor)
        {
            return _produtoService.FindByValue(valor);
        }
    }
}
