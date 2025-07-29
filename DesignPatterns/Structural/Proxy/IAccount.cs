namespace DesignPatterns.Structural.Proxy
{
    public interface IAccount
    {
        string GetAccountHolderName();
        decimal GetBalance();
        string GetTransactionHistory();
    }
}
