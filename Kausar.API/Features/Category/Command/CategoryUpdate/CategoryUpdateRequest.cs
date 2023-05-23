using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using QazLogistic.Domain.DTO;

namespace QazLogistic.Application.Features.Category.Command.CategoryUpdate
{
    public class CategoryUpdateRequest : IRequest<QazLogResponse<Unit>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
    }
}
