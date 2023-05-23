using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace QazLogistic.Application.Features.Product.Query.ProductGetList
{
    public class ProductGetListQuery : IRequestHandler<ProductGetListRequest, ProductGetListResponse>
    {
        public Task<ProductGetListResponse> Handle(ProductGetListRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
