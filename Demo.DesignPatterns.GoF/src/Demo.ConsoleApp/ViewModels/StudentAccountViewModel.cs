using Demo.Entities.Enums;

namespace Demo.ConsoleApp.ViewModels
{
    public class StudentAccountViewModel
    {
        #region ' Base properties '

        public int Number { get; set; }
        public decimal Balance { get; set; }
        public DateTimeOffset OpenedDate { get; set; }
        public bool IsActive { get; set; }

        #endregion ' Base properties '

        public StudentStatusType StudentStatus { get; set; }
        public string EnrolledInstitution { get; set; }
        public decimal LowBalanceAlert { get; set; }
        public bool HasParentalAccess { get; set; }
        public decimal ATMLimit { get; set; }
    }
}