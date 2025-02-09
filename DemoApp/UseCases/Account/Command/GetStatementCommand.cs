namespace DemoApp.UseCases.Account.Command
{
    public class GetStatementCommand : IRequest<AppResponse>
    {
        public DateTime? StateDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long CustomerCode { get; set; }
        public string AccountNumber { get; set; }
        public StatementTypeEnum StatementType { get; set; }
    }
}
