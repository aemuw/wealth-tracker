namespace wealth_tracker.Api.DTOs
{
    public class TransactionDto
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Type { get; set; } = string.Empty;
        public string TypeDisplay { get; set; } = string.Empty;
    }

    public class CreateTransactionDto
    {
        public DateTime Date { get; set; }
        public string Category { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Type { get; set; } = string.Empty;
    }

    public class UpdateTransactionDto
    {
        public DateTime Date { get; set; }
        public string Category { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Type { get; set; } = string.Empty;
    }
}
