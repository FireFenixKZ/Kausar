using QazLogistic.Application.Features.Category.Command.CategoryCreate;
using QazLogistic.Application.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QazLogistic.Domain.DTO;

namespace QazLogistic.Application.Features.Product.Command.ProductUpdate
{
    public class ProductUpdateCommand : IRequestHandler<ProductUpdateRequest, QazLogResponse<Unit>>
    {
        private readonly IASGroupContext _context;
        private readonly IMapper _mapper;

        public ProductUpdateCommand(IASGroupContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<QazLogResponse<Unit>> Handle(ProductUpdateRequest request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Kausar.Data.Entity.Category>(request);
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
            return new QazLogResponse<Unit>();
        }
    }
}
