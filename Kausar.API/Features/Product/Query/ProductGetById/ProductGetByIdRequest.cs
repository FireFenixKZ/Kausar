using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace QazLogistic.Application.Features.Product.Query.ProductGetById
{
    public class ProductGetByIdRequest : IRequest<ProductGetByIdResponse>
    {
        public int Id { get; set; }

        public ProductGetByIdRequest(int id)
        {
            this.Id = id;
        }
    }
}
