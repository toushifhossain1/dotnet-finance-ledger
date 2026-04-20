namespace FinanceSystem.Models;

public class JournalEntry
{
    public int JournalEntryId { get; set; }

    public DateTime Date { get; set; }

    public string Description { get; set; } = string.Empty;

    public bool IsPosted { get; set; } = false;

    public List<JournalLine> Lines { get; set; } = new();
}