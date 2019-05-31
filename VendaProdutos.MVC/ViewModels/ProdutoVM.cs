using System;
using System.ComponentModel.DataAnnotations;

namespace VendaProdutos.MVC.ViewModels
{
    public class ProdutoVM
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo obrigatorio para preenchimento")]
        [MaxLength(1000, ErrorMessage ="Maximo 1000 caracteres")]
        [MinLength(1, ErrorMessage ="Campo obrigatorio para preenchimento")]
        public string Descricao { get; set; }

        public DateTime Data { get; set; }

        [Required(ErrorMessage ="Informe o valor do produto")]
        public double Valor { get; set; }

        public bool Ativo { get; set; }
    }
}