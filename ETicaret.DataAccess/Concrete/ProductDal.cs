using ETicaret.Core.DataAccess;
using ETicaret.DataAccess.Abstract;
using ETicaret.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.DataAccess.Concrete
{
    public class ProductDal : EfEntityRepositoryBase<Product, ETicaretContext>, IProductDal
    {
        public ProductDal(ETicaretContext context):base(context)
        {

        }
    }
}
