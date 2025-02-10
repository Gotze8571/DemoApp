using MediatR;

namespace DemoApp.UseCases.Transfer.CommandHandler
{
    public class AccountCommandHandler : IRequestHandler<RequestForStatementCommand, AppResponse>
    {
    }
}
