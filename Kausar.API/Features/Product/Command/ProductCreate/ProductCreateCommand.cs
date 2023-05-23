﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QazLogistic.Application.Interfaces;
using AutoMapper;
using MediatR;
using QazLogistic.Domain.DTO;

namespace QazLogistic.Application.Features.Product.Command.ProductCreate
{
    public class ProductCreateCommand : IRequestHandler<ProductCreateRequest, QazLogResponse<Unit>>
    {
        private readonly IASGroupContext _context;
        private readonly IMapper _mapper;

        public ProductCreateCommand(IASGroupContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<QazLogResponse<Unit>> Handle(ProductCreateRequest request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Kausar.Data.Entity.Category>(request);
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return new QazLogResponse<Unit>();
        }
    }
}
