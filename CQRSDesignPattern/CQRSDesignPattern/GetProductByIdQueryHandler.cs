using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace CQRSDesignPattern
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        public Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            Product product = new Product() { Id = 1, Name = "Test", Price = 25 };
            return Task.FromResult(product);
        }
    }
}
