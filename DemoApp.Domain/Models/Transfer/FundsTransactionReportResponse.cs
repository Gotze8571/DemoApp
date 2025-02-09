using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Domain.Models.Transfer
{
    public class FundsTransactionReport
    {
        public long TransactionId { get; set; }
        public string SourceAccountName { get; set; }
        public string SourceAccount { get; set; }
        public string DestinationAccountName { get; set; }
        public string DestinationAccount { get; set; }
        public string DestinationBankCode { get; set; }
        public string DestinationBankName { get; set; }
        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; }
        public string PostedBy { get; set; }
       
        public string PaymentStatus { get; set; }
        public DateTime? DateProcessed { get; set; }
        public string Narration { get; set; }
       
    }
}
