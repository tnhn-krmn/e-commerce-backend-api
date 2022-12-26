using ECommerceBackend.Business.Abstract;
using ECommerceBackend.Business.Constants;
using ECommerceBackend.Core.Utilities.Results;
using ECommerceBackend.DataAccess.Abstract;
using ECommerceBackend.DataAccess.Concrete.EntityFramework;
using ECommerceBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            if (category.Name.Length == 2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _categoryDal.Add(category);
            return new SuccessResult(Messages.ProductAdded);
        }


        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.CategoryDeleted);
        }

        public IDataResult<List<Category>> GetList()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList());
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.CategoryUpdated);
        }
    }
}
