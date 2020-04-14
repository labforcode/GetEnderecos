using AutoMapper;
using GetEnderecos.Application.ViewModels.Enderecos;
using GetEnderecos.Domain.Entities.Enderecos;

namespace GetEnderecos.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Endereco, EnderecoViewModel>();
        }
    }
}
