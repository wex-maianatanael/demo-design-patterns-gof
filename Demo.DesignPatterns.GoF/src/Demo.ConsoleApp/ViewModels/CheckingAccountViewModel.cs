namespace Demo.ConsoleApp.ViewModels
{
    public class CheckingAccountViewModel
    {
        #region ' Base properties '

        public int Number { get; set; }
        public decimal Balance { get; set; }
        public DateTimeOffset OpenedDate { get; set; }
        public bool IsActive { get; set; }

        #endregion

        public decimal OverdraftLimit { get; set; }
        public int MonthlyFreeTransactions { get; set; }
        public decimal MonthlyFee { get; set; }
        public decimal TransactionFee { get; set; }
    }
}
