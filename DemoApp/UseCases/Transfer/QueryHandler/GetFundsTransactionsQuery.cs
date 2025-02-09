using MediatR;

namespace DemoApp.UseCases.Transfer.QueryHandler
{
    public class GetFundsTransactionsQuery : PaginationParameter, IRequest<Result<PagedResponse<FundsTransactionReportResponse>>>
    {
    }
}
