using API.Core.DbModels;
using API.Dtos;
using AutoMapper;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(dest => dest.ProductBrand, opt => opt.MapFrom(src => src.ProductBrand)) // Doğrudan eşleme
                .ForMember(dest => dest.ProductType, opt => opt.MapFrom(src => src.ProductType)); // Doğrudan eşleme
        }
    }
}
