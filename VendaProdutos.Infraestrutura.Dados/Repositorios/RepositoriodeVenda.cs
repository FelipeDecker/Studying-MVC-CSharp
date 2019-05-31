using System;
using System.Collections.Generic;
using System.Linq;
using VendaProdutos.Dominio.Entidades;
using VendaProdutos.Dominio.Interfaces.IRepositories;

namespace VendaProdutos.Infraestrutura.Dados.Repositorios
{
    public class RepositoriodeVenda : RepositorioBase<Venda>, IRepositoriodeVenda
    {
        public IEnumerable<Venda> FindByDate(DateTime data)
        {
            return DbContext.Vendas
                .Where(v => v.Data == data);
        }
    }
}
