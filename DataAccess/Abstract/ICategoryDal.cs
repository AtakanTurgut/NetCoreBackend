using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        /*
        List<Category> GetAll();
        void Add(Category category);
        void Updata(Category category);
        void Delete(Category category);

        List<Category> GetAllByCategory(int categoryId);
        */
    }
}
