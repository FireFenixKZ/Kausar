using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace QazLogistic.Application.Features.Product.Query.ProductGetById
{
    public class ProductGetByIdQuery : IRequestHandler<ProductGetByIdRequest, ProductGetByIdResponse>
    {
        public Task<ProductGetByIdResponse> Handle(ProductGetByIdRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
