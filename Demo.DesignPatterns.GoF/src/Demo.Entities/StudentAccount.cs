using Demo.Entities.Enums;

namespace Demo.Entities
{
    public class StudentAccount : BaseAccount
    {
        public StudentStatusType StudentStatus { get; set; }
        public string EnrolledInstitution { get; set; }
        public decimal LowBalanceAlert { get; set; }
        public bool HasParentalAccess { get; set; }
        public decimal ATMLimit { get; set; }
    }
}
