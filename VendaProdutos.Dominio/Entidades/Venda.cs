using System;
using System.Collections.Generic;

namespace VendaProdutos.Dominio.Entidades
{
    public class Venda
    {   
        public int Id { get; private set; }
        public DateTime Data { get; private set; }
        public ICollection<ItemVenda> ItemVenda { get; }

        public Venda()
        {
            Data = DateTime.Now;            
            ItemVenda = new List<ItemVenda>();
        }
    }
}
