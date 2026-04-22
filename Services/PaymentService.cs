using FinanceSystem.Models;

namespace FinanceSystem.Services;

public class PaymentService
{
    private readonly InvoiceService _invoiceService;
    private readonly JournalService _journalService;

    public PaymentService(InvoiceService invoiceService, JournalService journalService)
    {
        _invoiceService = invoiceService;
        _journalService = journalService;
    }

    public void MakePayment(int invoiceId, decimal amount)
    {
        var invoice = _invoiceService.GetById(invoiceId);

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

        var lines = new List<JournalLine>
            {
                new JournalLine
                {
                    AccountId = 1, // Cash
                    DebitAmount = amount,
                    CreditAmount = 0
                },
                new JournalLine
                {
                    AccountId = 2, // Accounts Receivable
                    DebitAmount = 0,
                    CreditAmount = amount
                }
            };

            _journalService.CreateJournalEntry(
                $"Payment received for Invoice {invoiceId}",
                lines
            );
    }
}