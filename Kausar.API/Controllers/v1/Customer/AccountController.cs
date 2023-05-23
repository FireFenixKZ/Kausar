using Kausar.API.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Kausar.API.Controllers.v1.Customer
{
    [Route("api/v{version:apiVersion}/account")]
    [ApiController]
    [ApiVersion("1.0")]
    public class AccountController : BaseController
    {
        [HttpPost]
        [Route("login")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(object))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> Login(CancellationToken cancellationToken)
        {
            return await _sender.Send(, cancellationToken);
        }

        [HttpPost]
        [Route("register")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(object))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> Registration(CancellationToken cancellationToken)
        {
            return await _sender.Send(, cancellationToken);
        }
    }
}
