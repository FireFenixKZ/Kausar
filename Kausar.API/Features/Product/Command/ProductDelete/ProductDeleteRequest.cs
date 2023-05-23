using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QazLogistic.Domain.DTO;
using MediatR;

namespace QazLogistic.Application.Features.Product.Command.ProductDelete
{
    public class ProductDeleteRequest : IRequest<QazLogResponse<Unit>>
    {
        public int Id { get; set; }
    }
}
