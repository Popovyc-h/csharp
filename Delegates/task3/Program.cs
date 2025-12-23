namespace CreditCard;

internal class Program
{
    static void Main(string[] args)
    {
        var card = new CreditCard("123-123", "Misha", "01.10", "2132", 100, 10);

        card.DepositBalance += (sender, eventArgs) =>
        {
            Console.WriteLine($"Deposited: {eventArgs.Amount}, New Balance: {eventArgs.Balance}");
        };

        card.TargetAmountReached += (sender, args) =>
        {
            Console.WriteLine("Target amount has been reached.");
        };

        card.WithdrawBalance += (sender, eventArgs) =>
        {
            Console.WriteLine($"Withdrew: {eventArgs.Amount}, New Balance: {eventArgs.Balance}");
        };

        card.CreditStarted += (sender, args) =>
        {
            Console.WriteLine("You started using credit money");
        };

        card.NewPIN += (sender, args) =>
        {
            Console.WriteLine("PIN was successfully changed.");
        };

        card.Deposit(500);
        card.Withdraw(555);

        card.ChangePIN("2132", "1111");
    }
}
