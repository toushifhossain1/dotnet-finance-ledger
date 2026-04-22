using FinanceSystem.Models;

namespace FinanceSystem.Services;

public class PaymentService
{
    private readonly InvoiceService _invoiceService;

    public PaymentService(InvoiceService invoiceService)
    {
        _invoiceService = invoiceService;
    }

    public void MakePayment(int invoiceId, decimal amount)
    {
        var invoice = _invoiceService.GetInvoice(invoiceId);

        if (invoice == null)
        {
            throw new Exception("Invoice not found");
        }

        if (amount <= 0)
        {
            throw new Exception("Invalid payment amount");
        }

        if (amount > invoice.DueAmount)
        {
            throw new Exception("Payment amount exceeds invoice due");
        }

        var payment = new Payment
        {
            PaymentId = 0, // temporary (DB will handle later)
            InvoiceId = invoiceId,
            Amount = amount,
            Date = DateTime.Now
        };

        invoice.Payments.Add(payment);
    }
}