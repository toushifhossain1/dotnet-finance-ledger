namespace FinanceSystem.Models;

public class Customer
{
    public int CustomerId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public List<Invoice> Invoices { get; set; } = new();
}