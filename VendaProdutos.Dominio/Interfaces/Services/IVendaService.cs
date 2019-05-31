using System;
using System.Collections.Generic;
using VendaProdutos.Dominio.Entidades;

namespace VendaProdutos.Dominio.Interfaces.Services
{
    public interface IVendaService : IServiceBase<Venda>
    {
        IEnumerable<Venda> FindByDate(DateTime data);
    }
}
