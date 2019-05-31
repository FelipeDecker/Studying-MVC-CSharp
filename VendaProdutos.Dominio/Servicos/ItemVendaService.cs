using System.Collections.Generic;
using VendaProdutos.Dominio.Entidades;
using VendaProdutos.Dominio.Interfaces.IRepositories;
using VendaProdutos.Dominio.Interfaces.Services;

namespace VendaProdutos.Dominio.Servicos
{
    public class ItemVendaService : ServiceBase<ItemVenda>, IItemVendaService
    {
        private readonly IRepositoriodeItemVenda _itemVendaRepository;

        public ItemVendaService(IRepositoriodeItemVenda itemVendaRepository) : base(itemVendaRepository)
        {
            _itemVendaRepository = itemVendaRepository;
        }

        public IEnumerable<ItemVenda> FindByAmount(int quantidade)
        {
            return _itemVendaRepository.FindByAmount(quantidade);
        }

        public IEnumerable<ItemVenda> FindByValue(double valor)
        {
            return _itemVendaRepository.FindByValue(valor);
        }
    }
}
