using System;
using System.Threading;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.Services
{
    public class ProductService : IProductService
    {
        IProductRepository productRepository;
        IRentalService rentalService;
        public ProductService(IProductRepository productRepository, IRentalService rentalService)
        {
            this.productRepository = productRepository;
            this.rentalService = rentalService;
        }
        public Product Delete(string Id, CancellationToken cancellationToken)
        {
            if (rentalService.HasRelationship(GetById(Id, cancellationToken)))
                return null;
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