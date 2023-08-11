namespace Demo.Entities
{
    public class CheckingAccount : BaseAccount
    {
        public decimal OverdraftLimit { get; private set; }
        public int MonthlyFreeTransactions { get; private set; }
        public decimal MonthlyFee { get; private set; }
        public decimal TransactionFee { get; private set; }

        public void SetOverdraftLimit(decimal limit)
        {
            this.OverdraftLimit = limit;
        }

        public void SetMonthlyFreeTransactions(int transactions)
        {
            this.MonthlyFreeTransactions = transactions;
        }

        public void SetMonthlyFee(decimal fee)
        {
            this.MonthlyFee = fee;
        }

        public void SetTransactionFee(decimal fee)
        {
            this.TransactionFee = fee;
        }

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