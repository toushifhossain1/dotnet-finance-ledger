public class CreateInvoiceRequest
{
    public int CustomerId { get; set; }
    public decimal Amount { get; set; }
    public DateTime DueDate { get; set; }
}