namespace CreditCard;

internal class CreditCard
{
    private string cardNumber;
    private string ownerName;
    private string expiryDate;
    private string pin;
    private decimal creditLimit;
    private decimal balance;

    public event EventHandler<CardTransactionEvent> DepositBalance;
    public event EventHandler<CardTransactionEvent> WithdrawBalance;
    public event EventHandler NewPIN;
    public event EventHandler CreditStarted;
    public event EventHandler TargetAmountReached;

    public CreditCard(string cardNumber, string ownerName, string expiryDate, string pin, decimal creditLimit, decimal balance)
    {
        CardNumber = cardNumber;
        OwnerName = ownerName;
        ExpiryDate = expiryDate;
        Pin = pin;
        CreditLimit = creditLimit;
        Balance = balance;
    }

    public void Deposit(decimal amount)
    {
        decimal TargetAmount = 500;
        decimal oldBalance = Balance;

        Balance += amount;
        DepositBalance?.Invoke(this, new CardTransactionEvent(amount, Balance));

        if (oldBalance < TargetAmount && Balance >= TargetAmount)
            TargetAmountReached?.Invoke(this, EventArgs.Empty);
    }

    public void Withdraw(decimal amount)
    {
        decimal oldBalance = Balance;

        if (amount > Balance + CreditLimit)
            throw new ArgumentException($"Transaction rejected! Insufficient funds for withdrawal {amount}", nameof(amount));

        Balance -= amount;
        WithdrawBalance?.Invoke(this, new CardTransactionEvent(amount, Balance));
        
        if (oldBalance >= 0 && Balance < 0)
            CreditStarted?.Invoke(this, EventArgs.Empty);
    }

    public void ChangePIN(string oldPIN, string newPIN)
    {
        if (oldPIN != Pin)
            throw new ArgumentException("Incorrect current PIN.", nameof(oldPIN));

        if (string.IsNullOrWhiteSpace(newPIN))
            throw new ArgumentException("New PIN cannot be empty", nameof(newPIN));

        if (newPIN == oldPIN)
            throw new ArgumentException("New PIN must be different from the current PIN.", nameof(newPIN));

        Pin = newPIN;
        NewPIN?.Invoke(this, EventArgs.Empty);
    }

    public string CardNumber
    {
        get => cardNumber;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Card number cannot be empty", nameof(CardNumber));

            cardNumber = value;
        }
    }

    public string OwnerName
    {
        get => ownerName;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Owner name cannot be empty", nameof(OwnerName));

            ownerName = value;
        }
    }

    public string ExpiryDate
    {
        get => expiryDate;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Expiry date cannot be empty", nameof(ExpiryDate));

            expiryDate = value;
        }
    }

    public string Pin
    {
        get => pin;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Pin cannot be empty", nameof(Pin));

            pin = value;
        }
    }

    public decimal CreditLimit
    {
        get => creditLimit;
        set
        {
            if (value < 0)
                throw new ArgumentException("The value cannot be negative", nameof(CreditLimit));

            creditLimit = value;
        }
    }

    public decimal Balance
    {
        get => balance;
        set => balance = value;
    }
}
