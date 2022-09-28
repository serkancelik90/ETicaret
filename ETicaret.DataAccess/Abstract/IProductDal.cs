using ETicaret.Core.DataAccess;
using ETicaret.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
