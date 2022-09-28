using ETicaret.Core.DataAccess;
using ETicaret.DataAccess.Abstract;
using ETicaret.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.DataAccess.Concrete
{
    public class OrderDal : EfEntityRepositoryBase<Order, ETicaretContext>, IOrderDal
    {
        public OrderDal(ETicaretContext context) : base(context)
        {

        }
    }
}
