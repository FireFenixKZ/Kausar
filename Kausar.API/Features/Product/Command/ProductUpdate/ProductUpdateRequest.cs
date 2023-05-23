using MediatR;
using QazLogistic.Domain.DTO;

namespace QazLogistic.Application.Features.Product.Command.ProductUpdate
{
    public class ProductUpdateRequest : IRequest<QazLogResponse<Unit>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
    }
}
