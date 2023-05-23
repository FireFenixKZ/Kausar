using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QazLogistic.Application.Features.Product.Command.ProductCreate
{
    public class ProductCreateProfile : Profile
    {
        public ProductCreateProfile()
        {
            CreateMap<ProductCreateRequest, Kausar.Data.Entity.Category>().ReverseMap();
        }
    }
}
