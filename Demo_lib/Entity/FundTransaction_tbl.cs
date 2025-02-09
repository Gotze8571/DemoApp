using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Data.Entity
{
    public class FundTransaction_tbl
    {
        [Key]
        public long TransactionID { get; set; }
        public string BulkNumber { get; set; }
        public long CustomerCode { get; set; }
        public string SourceAccountNumber { get; set; }
        public string SourceAccountName { get; set; }
        public string SourceAccountBranchCode { get; set; }
        public decimal Amount { get; set; }
        public decimal FeeAmount { get; set; }
        public decimal VatAmount { get; set; }
        public string BeneficiaryAccountNumber { get; set; }
        public string BeneficiaryAccountName { get; set; }
        public string BeneficiaryBankCode { get; set; }
        public string? BeneficiaryBank { get; set; } = string.Empty;
        public string Narration { get; set; }
        public string? TransactionCategory { get; set; }
        public string? TransactionType { get; set; }
        public FundsTransferMode TransactionMode { get; set; }
        public FundsTransferDebitMode DebitMode { get; set; }
        public FundsTransferChannel TransactionChannel { get; set; }
        public FundsTransferOccurrence Occurrence { get; set; }
        public TransactionChannel ProcessingChannel { get; set; }
        public DateTime? DebitValueDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string NEResponse { get; set; }
        public string? SessionID { get; set; }
        public string? PaymentReference { get; set; }
        public string PostedBy { get; set; }
        public DateTime DatePosted { get; set; }
        public int ApprovalStatus { get; set; } = 0;
        public string? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? RejectedBy { get; set; }
        public DateTime? RejectedDate { get; set; }
        public string? RejectedReason { get; set; }
        public int? IsSuspenseTreated { get; set; }
        public int? PaymentStatus { get; set; }
        public string? ResponseCode { get; set; }
        public string? ResponseText { get; set; }
        public string? FTReference { get; set; }
        public DateTime? DateProcessed { get; set; }
        public string? NIPResponse { get; set; }
        public string? NAPSResponse { get; set; }
        public string? NEFTResponse { get; set; }
        public string? FraudScore { get; set; }
        public string? FraudResponse { get; set; }
        public string? ApplicationComment { get; set; }
        public int? ReversalStatus { get; set; }
        public int? LockFundsStatus { get; set; }
        public DateTime? LockFundsStartDate { get; set; }
        public DateTime? LockFundsEndDate { get; set; }
        public string? LockFundsResponseCode { get; set; }
        public string? LockFundsDescription { get; set; }
        public string? LockFundsID { get; set; }
        public int? RetrialCount { get; set; }
        public string? PrincipalFTReference { get; set; }
        public string? FeeFTReference { get; set; }
        public string? VATFTReference { get; set; }
        public string? PreferredNextLevelUser { get; set; } = null;
        public int? ApprovalCount { get; set; }
        public bool IsScheduledPayment { get; set; } = false;

        public bool IsProcessCompleted { get; set; } = false;
        public bool IsCompletedNotificationSent { get; set; } = false;
        public DateTime? ScheduledPaymentDate { get; set; }

        public DateTime? ScheduledProcessDate { get; set; }

        public int? Frequency { get; set; }

        public int? RetryAttempt { get; set; }
    }
}
