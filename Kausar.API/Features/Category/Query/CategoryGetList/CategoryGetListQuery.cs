using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace QazLogistic.Application.Features.Category.Query.CategoryGetList
{
    public class CategoryGetListQuery : IRequestHandler<CategoryGetListRequest, CategoryGetListResponse>
    {
        public Task<CategoryGetListResponse> Handle(CategoryGetListRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
