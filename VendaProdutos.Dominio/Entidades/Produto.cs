using System;
using System.Collections.Generic;

namespace VendaProdutos.Dominio.Entidades
{
    public class Produto
    {
        public int          Id              { get; private set; }

        public string       Descricao       { get; private set; }

        public double       Valor           { get; private set; }

        public DateTime     Data            { get; private set; }

        public bool         Ativo           { get; private set; }

        public ICollection<ItemVenda> ItemVenda { get; private set; }

        protected Produto()
        {

        }

        public Produto(string descricao, double valor, bool ativo)
        {
            Descricao = descricao;
            Valor = valor;
            Ativo = ativo;
            Data = DateTime.Now;
        }

        public void UpdateProduto(string descricao, double valor, bool ativo)
        {
            Descricao = descricao;
            Valor = valor;
            Ativo = ativo;
        }

        public void InativarProduto()
        {
            Ativo = false;
        }
    }
}
