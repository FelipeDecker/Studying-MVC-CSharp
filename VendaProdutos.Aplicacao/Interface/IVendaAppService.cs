using System;
using System.Collections.Generic;
using VendaProdutos.Dominio.Entidades;

namespace VendaProdutos.Aplicacao.Interface
{
    public interface IVendaAppService : IAppServiceBase<Venda>
    {
        IEnumerable<Venda> FindByDate(DateTime data);
    }
}
