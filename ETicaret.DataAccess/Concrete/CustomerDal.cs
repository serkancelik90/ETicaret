using ETicaret.Core.DataAccess;
using ETicaret.DataAccess.Abstract;
using ETicaret.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.DataAccess.Concrete
{
    public class CustomerDal:EfEntityRepositoryBase<Customer, ETicaretContext>, ICustomerDal
    {
        public CustomerDal(ETicaretContext context) : base(context)
        {

        }
    }
}
