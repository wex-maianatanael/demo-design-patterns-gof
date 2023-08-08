namespace Demo.Entities
{
    public class CheckingAccount : BaseAccount
    {
        public decimal OverdraftLimit { get; set; }
        public int MonthlyFreeTransactions { get; set; }
        public decimal MonthlyFee { get; set; }
        public decimal TransactionFee { get; set; }
    }
}
