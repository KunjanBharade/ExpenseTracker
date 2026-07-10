public class Transaction
{
    public Guid Id { get; set; }

    public DateTime Date { get; set; }

    public decimal Amount { get; set; }

    public bool IsIncome { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
}
