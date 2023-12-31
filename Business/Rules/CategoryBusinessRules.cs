﻿using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Reles
{
    public class CategoryBusinessRules : BaseBusinessRules
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryBusinessRules(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public async Task MaximumCategoryCountIsTen()
        {
            var result = await _categoryDal.GetListAsync();

            if (result.Count >= 10)
            {
                throw new Exception("Max Limit 10");
            }

        }
    }
}
