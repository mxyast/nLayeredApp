using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Business.Reles;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {

        private ICategoryDal _categoryDal;
        private IMapper _mapper;
        private CategoryBusinessRules _categoryBusinessRules;
        public CategoryManager(ICategoryDal categoryDal, IMapper mapper, CategoryBusinessRules categoryBusinessRules)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
            _categoryBusinessRules = categoryBusinessRules;

        }

        public async Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest)
        {
            await _categoryBusinessRules.MaximumCategoryCountIsTen();

            Category category = _mapper.Map<Category>(createCategoryRequest);

            var createdCategory = await _categoryDal.AddAsync(category);

            CreatedCategoryResponse result = _mapper.Map<CreatedCategoryResponse>(createdCategory);

            return result;
        }
        public async Task<Paginate<GetListCategoryResponse>> GetListAsync()
        {
            var data = await _categoryDal.GetListAsync();

            return _mapper.Map<Paginate<GetListCategoryResponse>>(data);
        }
    }
}
