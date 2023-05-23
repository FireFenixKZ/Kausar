using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QazLogistic.Domain.DTO;
using MediatR;

namespace QazLogistic.Application.Features.Category.Command.CategoryCreate
{
    public class CategoryCreateRequest : IRequest<QazLogResponse<Unit>>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
    }
}
