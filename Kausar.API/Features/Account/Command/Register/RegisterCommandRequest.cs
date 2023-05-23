using KDS.Primitives.FluentResult;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace QazLogistic.Application.Features.Account.Command.Register
{
    public class RegisterCommandRequest : IRequest<Result<string>>
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
