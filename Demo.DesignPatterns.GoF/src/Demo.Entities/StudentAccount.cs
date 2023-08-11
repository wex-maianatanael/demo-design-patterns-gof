using Demo.Entities.Enums;

namespace Demo.Entities
{
    public class StudentAccount : BaseAccount
    {
        public StudentStatusType StudentStatus { get; private set; }
        public string EnrolledInstitution { get; private set; }
        public decimal LowBalanceAlert { get; private set; }
        public bool HasParentalAccess { get; private set; }
        public decimal ATMLimit { get; private set; }

        public void SetStudentStatus(StudentStatusType status)
        {
            this.StudentStatus = status;
        }

        public void SetEnrolledInstitution(string institution)
        {
            this.EnrolledInstitution = institution;
        }

        public void SetLowBalanceAlert(decimal lowBalanceAlert)
        {
            this.LowBalanceAlert = lowBalanceAlert;
        }

        public void SetHasParentalAccess(bool hasParentalAccess)
        {
            this.HasParentalAccess = hasParentalAccess;
        }

        public void SetATMLimit(decimal limit)
        {
            this.ATMLimit = limit;
        }

        public override string ToString()
        {
            return $"ID: {ID}\n" +
                $"Account Number: {Number}\n" +
                $"Balance: {Balance}\n" +
                $"Open Date: {OpenedDate}\n" +
                $"Is Active: {IsActive}\n" +
                $"Student Status: {StudentStatus}\n" +
                $"Enrolled Institution: {EnrolledInstitution}\n" +
                $"Low Balance Alert: {LowBalanceAlert}\n" +
                $"Has Parental Access: {HasParentalAccess}\n" +
                $"ATM Limit: {ATMLimit}\n\n";
        }
    }
}