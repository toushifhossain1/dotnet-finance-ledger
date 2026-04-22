using FinanceSystem.Models;

namespace FinanceSystem.Services;

public class JournalService
{
    private readonly List<JournalEntry> _journalEntries = new();

    public JournalEntry CreateJournalEntry(string description, List<JournalLine> lines)
    {
        if (lines == null || lines.Count == 0)
            throw new Exception("Journal must have at least one line");

        decimal totalDebit = lines.Sum(l => l.DebitAmount);
        decimal totalCredit = lines.Sum(l => l.CreditAmount);

        if (totalDebit != totalCredit)
            throw new Exception("Journal entry is not balanced");

        // Validate each line
        foreach (var line in lines)
        {
            if (line.DebitAmount > 0 && line.CreditAmount > 0)
                throw new Exception("Line cannot have both debit and credit");

            if (line.DebitAmount == 0 && line.CreditAmount == 0)
                throw new Exception("Line must have debit or credit");
        }

        var entry = new JournalEntry
        {
            JournalEntryId = _journalEntries.Count + 1,
            Date = DateTime.Now,
            Description = description,
            IsPosted = true,
            Lines = lines
        };

        _journalEntries.Add(entry);

        return entry;
    }

    public List<JournalEntry> GetAll()
    {
        return _journalEntries;
    }
}