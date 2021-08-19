using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Boilerplate.Api.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        [ApiController]
        [Route("api/v{version:apiVersion}/[controller]")]
        public abstract class BaseApiController<T> : ControllerBase
        {
            private ILogger<T> _loggerInstance;
            protected ILogger<T> _logger => _loggerInstance ??= HttpContext.RequestServices.GetService<ILogger<T>>();
        }
    }
}