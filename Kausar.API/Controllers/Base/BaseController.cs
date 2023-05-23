using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Kausar.API.Controllers.Base
{
    public class BaseController : ControllerBase
    {
        protected ISender _sender => (ISender)HttpContext.RequestServices.GetService(typeof(ISender));
        //protected IHttpContextAccessor _contextAccessor;
    }
}
