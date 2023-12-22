using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        Task<Paginate<GetListCategoryResponse>> GetListAsync();

        Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest);
    }
}
