using FinanceSystem.Models;
namespace FinanceSystem.Services;

public class InvoiceService
{
    private readonly List<Invoice> _invoices = new();

    public Invoice createInvoice(int customerId, decimal amount, DateTime dueDate)
    {
        var invoice = new Invoice
        {
            InvoiceId = _invoices.Count + 1,
            CustomerId = customerId,
            TotalAmount = amount,
            DueDate = dueDate
        };
        _invoices.Add(invoice);
        return invoice;
    }

    public Invoice? GetInvoice(int invoiceId)
    {
        return _invoices.FirstOrDefault(i => i.InvoiceId == invoiceId);
    }

    public List<Invoice> GetAllInvoices()
    {
        return _invoices;
    }
}