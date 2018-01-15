using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class ProductService : IProductService
    {
        public Product Delete(string Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Product[] GetAll(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Product GetById(string Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public bool Post(Product Product, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}