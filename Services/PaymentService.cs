using FinanceSystem.Models;
namespace FinanceSystem.Services;

public class PaymentService
{
    private readonly List<Invoice> _invoices;
    
    public PaymentService(List<Invoice> invoices)
    {
        _invoices = invoices;
    }

    public void MakePayment (int incoideID, decimal amount)
    {
        var invoice = _invoices.FirstOrDefault(i => i.InvoiceId == incoideID);
        
        if (invoice == null )
        {
            throw new Exception("Invoice not found");
        }

        if (amount <=0)
        {
            throw new Exception("Invalid payment amount");
        }

        decimal due = invoice.TotalAmount - invoice.Payments.Sum(p => p.Amount);

        if (amount > due)
        {
            throw new Exception("Payment amount exceeds invoice due");
        }

    }
}