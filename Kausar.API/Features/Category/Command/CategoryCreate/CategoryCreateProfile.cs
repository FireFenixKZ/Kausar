using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QazLogistic.Application.Features.Category.Command.CategoryCreate
{
    public class CategoryCreateProfile : Profile
    {
        public CategoryCreateProfile()
        {
            CreateMap<CategoryCreateRequest, Kausar.Data.Entity.Category>().ReverseMap();
        }
    }
}
