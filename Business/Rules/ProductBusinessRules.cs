using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Reles
{
    public class ProductBusinessRules : BaseBusinessRules
    {
        private readonly IProductDal _productDal;

        public ProductBusinessRules(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public async Task EachCategoryCanContainMax20Products(Guid categoryId)
        {
            var result = await _productDal.GetListAsync(
                predicate: p => p.CategoryId == categoryId
                );

            if (result.Count >= 20)
            {
                throw new Exception("CategoryProductLimit");
            }

        }
    }
}
