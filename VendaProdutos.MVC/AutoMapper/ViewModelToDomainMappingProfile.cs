using AutoMapper;
using VendaProdutos.Dominio.Entidades;
using VendaProdutos.MVC.ViewModels;

namespace VendaProdutos.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProdutoVM, Produto>();
            CreateMap<VendaVM, Venda>();
        }
    }
}