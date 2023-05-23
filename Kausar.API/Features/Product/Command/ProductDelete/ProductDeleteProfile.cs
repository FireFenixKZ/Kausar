using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QazLogistic.Application.Features.Product.Command.ProductDelete
{
    public class ProductDeleteProfile : Profile
    {
        public ProductDeleteProfile()
        {
            CreateMap<ProductDeleteRequest, Kausar.Data.Entity.Category>().ReverseMap();
        }
    }
}
