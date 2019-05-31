using System;
using System.Collections.Generic;
using VendaProdutos.Aplicacao.Interface;
using VendaProdutos.Dominio.Entidades;
using VendaProdutos.Dominio.Interfaces.Services;

namespace VendaProdutos.Aplicacao
{
    public class VendaAppService : AppServiceBase<Venda>, IVendaAppService
    {
        private readonly IVendaService _vendaService;

        public VendaAppService(IVendaService vendaService) : base(vendaService)
        {
            _vendaService = vendaService;
        }

        public IEnumerable<Venda> FindByDate(DateTime data)
        {
            return _vendaService.FindByDate(data);
        }
    }
}
