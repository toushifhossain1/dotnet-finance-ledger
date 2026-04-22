namespace FinanceSystem.Models;

public class Invoice
{
    public int InvoiceId { get; set; }

    public int CustomerId { get; set; }

    public decimal TotalAmount { get; set; }

    public DateTime DueDate { get; set; }

    public List<Payment> Payments { get; set; } = new();

    public decimal PaidAmount => Payments.Sum(p => p.Amount);

    public decimal DueAmount => TotalAmount - PaidAmount;
}