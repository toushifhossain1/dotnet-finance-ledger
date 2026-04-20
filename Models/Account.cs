namespace FinanceSystem.Models;

public enum AccountType
        {
            Asset,
            Liability,
            Income,
            Expense
        }

public class Account
{
    public int AccountId { get; set; }
    public string AccountName { get; set; } = string.Empty;

    public AccountType Type { get; set; }
    public decimal OpeningBalance { get; set; }
     public bool IsActive { get; set; } = true;

}