using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Business.Reles;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        IMapper _mapper;
        ProductBusinessRules _productBusinessRules;

        public ProductManager(IProductDal productDal, IMapper mapper, ProductBusinessRules productBusinessRules)
        {
            _productDal = productDal;
            _mapper = mapper;
            _productBusinessRules = productBusinessRules;
        }

        public async Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest)
        {
            // await _productBusinessRules.EachCategoryCanContainMax20Products(createProductRequest.CategoryId);
            Product product = _mapper.Map<Product>(createProductRequest);
            product.Id = Guid.NewGuid();

            Product createdProduct = await _productDal.AddAsync(product);

            CreatedProductResponse createdProductResponse = _mapper.Map<CreatedProductResponse>(createdProduct);

            return createdProductResponse;
        }

        public async Task<Paginate<GetListProductResponse>> GetListAsync()
        {
            var data = await _productDal.GetListAsync(include: p => p.Include(p => p.Category));

            return _mapper.Map<Paginate<GetListProductResponse>>(data);
        }
    }
}
