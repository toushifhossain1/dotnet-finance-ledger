namespace FinanceSystem.Models;

public class JournalLine
{
    public int JournalLineId { get; set; }

    public int JournalEntryId { get; set; }

    public int AccountId { get; set; }

    public decimal DebitAmount { get; set; }
    public decimal CreditAmount { get; set; }

    public Account? Account { get; set; }
}