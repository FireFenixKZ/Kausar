using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace QazLogistic.Application.Features.Product.Query.ProductGetList
{
    public class ProductGetListRequest : IRequest<ProductGetListResponse>
    {
    }
}
