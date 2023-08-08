namespace Demo.Entities
{
    public class CheckingAccount : BaseAccount
    {
        public decimal OverdraftLimit { get; set; }
        public int MonthlyFreeTransactions { get; set; }
        public decimal MonthlyFee { get; set; }
        public decimal TransactionFee { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}\n" +
                $"Account Number: {Number}\n" +
                $"Balance: {Balance}\n" +
                $"Open Date: {OpenedDate}\n" +
                $"Is Active: {IsActive}\n" +
                $"Overdraft Limit: {OverdraftLimit}\n" +
                $"MonthlyFreeTransactions: {MonthlyFreeTransactions}\n" +
                $"Monthly Fee: {MonthlyFee}\n" +
                $"Transaction Fee: {TransactionFee}\n\n";
        }
    }
}
