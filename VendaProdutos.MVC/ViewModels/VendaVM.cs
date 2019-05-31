using System;
using System.ComponentModel.DataAnnotations;

namespace VendaProdutos.MVC.ViewModels
{
    public class VendaVM
    {
        [Key]
        public int Id { get; set; }
        public DateTime Data { get; set; }
    }
}