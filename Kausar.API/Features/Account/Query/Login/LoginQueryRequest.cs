using Kausar.API.DTO;
using KDS.Primitives.FluentResult;
using MediatR;

namespace QazLogistic.Application.Features.Account.Query.Login
{
    public class LoginQueryRequest : IRequest<Result>
    {
        public LoginDTO loginDTO { get; set; }
    }
}
