using QazLogistic.Application.Features.Product.Command.ProductCreate;
using QazLogistic.Application.Features.Product.Command.ProductUpdate;
using System.Reflection;

namespace QazLogistic.Application
{
    public static class ApplicationServiceCollection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            //Adding AutoMapper for each feature
            services.AddAutoMapper(typeof(ProductCreateProfile));
            services.AddAutoMapper(typeof(ProductUpdateProfile));
        }
    }
}
