using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace QazLogistic.Application.Features.Category.Query.CategoryGetById
{
    public class CategoryGetByIdQuery : IRequestHandler<CategoryGetByIdRequest, CategoryGetByIdResponse>
    {
        public Task<CategoryGetByIdResponse> Handle(CategoryGetByIdRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
