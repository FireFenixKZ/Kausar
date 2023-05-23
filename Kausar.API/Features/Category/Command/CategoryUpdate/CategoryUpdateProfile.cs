using QazLogistic.Application.Features.Category.Command.CategoryCreate;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QazLogistic.Application.Features.Category.Command.CategoryUpdate
{
    public class CategoryUpdateProfile : Profile
    {
        public CategoryUpdateProfile()
        {
            CreateMap<CategoryUpdateRequest, Kausar.Data.Entity.Category>().ReverseMap();
        }
    }
}
