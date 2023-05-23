using QazLogistic.Application.Features.Category.Command.CategoryCreate;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QazLogistic.Application.Features.Product.Command.ProductUpdate
{
    public class ProductUpdateProfile : Profile
    {
        public ProductUpdateProfile()
        {
            CreateMap<ProductUpdateRequest, Kausar.Data.Entity.Category>().ReverseMap();
        }
    }
}
