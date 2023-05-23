using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QazLogistic.Domain.DTO;
using MediatR;

namespace QazLogistic.Application.Features.Category.Command.CategoryDelete
{
    public class CategoryDeleteRequest : IRequest<QazLogResponse<Unit>>
    {
        public int Id { get; set; }
    }
}
