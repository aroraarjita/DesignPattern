using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace CQRSDesignPattern
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        public Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            // Logic to create a new product and return its ID
            int newProductId = 1/* Add logic to create a new product */;
            return Task.FromResult(newProductId);
        }
    }
}
