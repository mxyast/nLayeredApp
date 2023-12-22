using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IProductService
    {
        Task<Paginate<GetListProductResponse>> GetListAsync();
        Task<CreatedProductResponse> Add(CreateProductRequest crateProductRequest);
    }
}
