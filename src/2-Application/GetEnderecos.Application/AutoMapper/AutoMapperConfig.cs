using AutoMapper;

namespace GetEnderecos.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(config =>
            {
                config.AddProfile<DomainToViewModelMappingProfile>();
                //config.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}
