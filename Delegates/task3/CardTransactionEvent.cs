namespace CreditCard;

public class CardTransactionEvent(decimal amount, decimal balance) : EventArgs
{
    public decimal Amount { get; } = amount;

    public decimal Balance { get; } = balance;
}
