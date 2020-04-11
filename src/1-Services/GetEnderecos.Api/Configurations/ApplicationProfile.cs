using GetEnderecos.Application.ViewModels.Enderecos;
using GetEnderecos.Domain.Entities.Enderecos;

namespace GetEnderecos.Api.Configurations
{
    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Endereco, EnderecoViewModel>()
                .ReverseMap();
        }
    }
}
