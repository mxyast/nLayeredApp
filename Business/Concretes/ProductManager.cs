using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        private readonly IMapper _mapper;

        public ProductManager(IProductDal productDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper=mapper;
        }
      
        public async Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest)
       {
            Product product = _mapper.Map<Product>(createProductRequest);
            var createProduct=await _productDal.AddAsync(product);
            return _mapper.Map<CreatedProductResponse>(createProduct); 
            //Product product = new Product();
            //product.Id = Guid.NewGuid();
            //product.ProductName = createProductRequest.ProductName;
            //product.QuantityPerUnit = createProductRequest.QuantityPerUnit;
            //product.UnitPrice = createProductRequest.UnitPrice;
            //product.UnitsInStock = createProductRequest.UnitsInStock;

            //Product cratedProduct = await _productDal.AddAsync(product);

            //CreatedProductResponse createdProductResponse = new CreatedProductResponse();
            //createdProductResponse.Id = cratedProduct.Id;
            //createdProductResponse.ProductName = cratedProduct.ProductName;
            //createdProductResponse.QuantityPerUnit = cratedProduct.QuantityPerUnit;
            //createdProductResponse.UnitPrice = cratedProduct.UnitPrice;
            //createdProductResponse.UnitsInStock = cratedProduct.UnitsInStock;
            //return createdProductResponse;
        }



        public async Task<Paginate<CreatedProductResponse>> GetListAsync()
        {

           // Paginate<CreatedProductResponse> paginateCreatedProductResponse = new Paginate<CreatedProductResponse>();
            var result = await _productDal.GetListAsync();
            return _mapper.Map<Paginate<CreatedProductResponse>>(result);
           // IList<CreatedProductResponse> list = _mapper.Map<List<CreatedProductResponse>>(result);

            //IList<CreatedProductResponse> getList=new List<CreatedProductResponse>();

            //foreach (var item in result.Items)
            //{
            //    CreatedProductResponse createdProductResponse = new CreatedProductResponse();
            //    createdProductResponse.Id = item.Id;
            //    createdProductResponse.ProductName = item.ProductName;
            //    createdProductResponse.UnitPrice = item.UnitPrice;
            //    createdProductResponse.UnitsInStock = item.UnitsInStock;
            //    createdProductResponse.QuantityPerUnit = item.QuantityPerUnit;
            //    getList.Add(createdProductResponse);
            //}


            //paginateCreatedProductResponse.Size = result.Size;
            //paginateCreatedProductResponse.Index = result.Index;
            //paginateCreatedProductResponse.Pages = result.Pages;
            //paginateCreatedProductResponse.Count = result.Count;
            //paginateCreatedProductResponse.Items = list;

            //return paginateCreatedProductResponse;
        }


    }
}
