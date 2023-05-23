using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace QazLogistic.Application.Features.Category.Query.CategoryGetById
{
    public class CategoryGetByIdRequest : IRequest<CategoryGetByIdResponse>
    {
        public int  Id { get; set; }   
    }
}
