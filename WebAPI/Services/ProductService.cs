using System;
using System.Threading;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.Services
{
    public class ProductService : IProductService
    {
        IProductRepository productRepository;
        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public Product Delete(string Id, CancellationToken cancellationToken)
        {
            return productRepository.Delete(Id);
        }

        public Product[] GetAll(CancellationToken cancellationToken)
        {
            return productRepository.GetAll();
        }

        public Product GetById(string Id, CancellationToken cancellationToken)
        {
            return productRepository.GetById(Id);
        }

        public Product Post(Product Product, CancellationToken cancellationToken)
        {
            return productRepository.Post(Product);
        }
    }
}