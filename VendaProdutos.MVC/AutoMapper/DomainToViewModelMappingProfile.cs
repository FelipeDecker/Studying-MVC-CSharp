using AutoMapper;
using VendaProdutos.Dominio.Entidades;
using VendaProdutos.MVC.ViewModels;

namespace VendaProdutos.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Produto, ProdutoVM>();
            CreateMap<Venda, VendaVM>();
        }
    }
}