using System.Collections.Generic;
using VendaProdutos.Aplicacao.Interface;
using VendaProdutos.Dominio.Entidades;
using VendaProdutos.Dominio.Interfaces.Services;

namespace VendaProdutos.Aplicacao
{
    public class ItemVendaAppService : AppServiceBase<ItemVenda>, IItemVendaAppService
    {
        private readonly IItemVendaService _itemVendaService;

        public ItemVendaAppService(IItemVendaService itemVendaService) : base(itemVendaService)
        {
            _itemVendaService = itemVendaService;
        }

        public IEnumerable<ItemVenda> FindByAmount(int quantidade)
        {
            return _itemVendaService.FindByAmount(quantidade);
        }

        public IEnumerable<ItemVenda> FindByValue(double valor)
        {
            return _itemVendaService.FindByValue(valor);
        }
    }
}
