using FinanceSystem.Models;
namespace FinanceSystem.Services;

public class JournalEntryValidation
{
    public void journalEntryValidation(JournalEntry journalEntry)
    {
        if (journalEntry.Lines == null || !journalEntry.Lines.Any())
        {
            throw new ArgumentException("Journal entry must have at least one line.");
        }

        decimal totalDebit = journalEntry.Lines.Sum(line => line.DebitAmount);
        decimal totalCredit = journalEntry.Lines.Sum(line => line.CreditAmount);

        if (totalDebit != totalCredit)
        {
            throw new ArgumentException("Total debit and credit amounts must be equal.");
        }
    }
    
}