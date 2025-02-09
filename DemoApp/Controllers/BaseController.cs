using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected readonly IMediator _mediator;
        public BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        private IConfiguration _configuration = null!;

        /// <summary>
        /// Gets the base url of a request
        /// </summary>
        /// <returns></returns>
        private string GetOriginFromRequest() => $"{Request.Scheme}://{Request.Host.Value}{Request.PathBase.Value}";

        protected IConfiguration Configuration => _configuration ??= HttpContext.RequestServices.GetRequiredService<IConfiguration>();

        /// <summary>
        /// Used to get clients Ip Address
        /// </summary>
        /// <returns></returns>
        private string? GetIpAddress() =>
        Request.Headers.ContainsKey("X-Forwarded-For")
            ? Request.Headers["X-Forwarded-For"]
            : HttpContext.Connection.RemoteIpAddress?.MapToIPv4().ToString() ?? "N/A";

        internal IActionResult HandleResult(Result result)
        {
            if (result == null) return NotFound();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        internal IActionResult HandleEncryptedResult(Result result)
        {
            if (result == null) return NotFound();
            var encyrptedValue = EncryptResult(result);
            return result.IsSuccess ? Ok(encyrptedValue) : BadRequest(encyrptedValue);
        }

        internal string EncryptResult<T>(T result) where T : class
        {
            var key = Configuration.GetValue<string>("AppSettings:ApiSecretKey") ?? string.Empty;
            var iv = Configuration.GetValue<string>("AppSettings:ApiSecretIV") ?? string.Empty;
            return CryptographicUtility.EncryptStringAES128(result.ToJson(), key, iv);
        }

        internal T DecryptPayloadRequest<T>(string requestPayload) where T : class
        {
            var key = Configuration.GetValue<string>("AppSettings:ApiSecretKey") ?? string.Empty;
            var iv = Configuration.GetValue<string>("AppSettings:ApiSecretIV") ?? string.Empty;
            return requestPayload.DecryptPayloadRequest<T>(key, iv);
        }
    }
}
