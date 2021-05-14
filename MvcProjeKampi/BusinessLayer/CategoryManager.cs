using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

 

        public void CategoryAdd(Category category)
        {
            _categoryDal.İnsert(category);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        public void CategoryAddBL()
        {
            throw new NotImplementedException();
        }

        public Category GetByID(int id)
        {
            return _categoryDal.Get(x => x.CategoryID == id);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
           
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
