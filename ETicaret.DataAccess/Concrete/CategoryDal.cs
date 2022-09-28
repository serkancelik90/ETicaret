using ETicaret.Core.DataAccess;
using ETicaret.DataAccess.Abstract;
using ETicaret.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.DataAccess.Concrete
{
    public class CategoryDal : EfEntityRepositoryBase<Category, ETicaretContext>, ICategoryDal
    {
        public CategoryDal(ETicaretContext context) : base(context)
        {

        }
    }
}
