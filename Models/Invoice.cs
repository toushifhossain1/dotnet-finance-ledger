namespace FinanceSystem.Models;

public class Invoice
{
    public int InvoiceId { get; set; }

    public int CustomerId { get; set; }

    public decimal TotalAmount { get; set; }

    public List<Payment> Payments { get; set; } = new();
}
