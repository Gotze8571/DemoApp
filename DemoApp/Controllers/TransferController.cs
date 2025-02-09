using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DemoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : BaseController
    {
        public TransferController(IMediator mediator) : base(mediator)
        {
        }
        /// <summary>
        /// End point to fetch funds transfer transactions
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet("transactions")]
        [ProducesResponseType(typeof(Result<PagedResponse<FundsTransferReportResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetFundsTransferTransactions([FromQuery] GetFundsTransferTransactionsQuery query)
          => HandleResult(await _mediator.Send(query));

    }
}
