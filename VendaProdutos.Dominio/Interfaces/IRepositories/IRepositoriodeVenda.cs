using System;
using System.Collections.Generic;
using VendaProdutos.Dominio.Entidades;

namespace VendaProdutos.Dominio.Interfaces.IRepositories
{
    public interface IRepositoriodeVenda : IRepositoryBase<Venda>
    {
        IEnumerable<Venda> FindByDate(DateTime data);
    }
}
