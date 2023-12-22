using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Mapping
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {

            CreateMap<Product, GetListProductResponse>()
            .ForMember(destinationMember: p => p.CategoryName,
                      memberOptions: opt => opt.MapFrom(p => p.Category.Name)).ReverseMap();

            CreateMap<Paginate<Product>, Paginate<GetListProductResponse>>().ReverseMap();
            CreateMap<Product, CreateProductRequest>().ReverseMap();
            CreateMap<Product, CreatedProductResponse>().ReverseMap();

        }

    }
}
