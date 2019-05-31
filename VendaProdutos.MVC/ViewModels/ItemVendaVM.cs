using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VendaProdutos.Dominio.Entidades;

namespace VendaProdutos.MVC.ViewModels
{
    public class ItemVendaVM
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Produto")]
        public int IdProduto { get; set; }

        [DisplayName("Venda")]
        public int IdVenda { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio para preenchimento")]
        public int Quantidade { get; set; }

        public double Valor { get; set; }

        public Produto Produto { get; set; }

        public Venda Venda { get; set; }

        public virtual IEnumerable<ProdutoVM> Produtos { get; set; }

    }
}