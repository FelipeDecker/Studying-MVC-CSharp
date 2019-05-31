using System;
using System.Collections.Generic;
using VendaProdutos.Dominio.Entidades;
using VendaProdutos.Dominio.Interfaces.IRepositories;
using VendaProdutos.Dominio.Interfaces.Services;

namespace VendaProdutos.Dominio.Servicos
{
    public class VendaService : ServiceBase<Venda>, IVendaService
    {
        private readonly IRepositoriodeVenda _vendaRepository;

        public VendaService(IRepositoriodeVenda vendaRepository) : base(vendaRepository)
        {
            _vendaRepository = vendaRepository;
        }

        public IEnumerable<Venda> FindByDate(DateTime data)
        {
            return _vendaRepository.FindByDate(data);
        }
    }
}
