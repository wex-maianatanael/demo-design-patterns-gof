using Demo.Builder.Builders.Contracts;
using Demo.Entities;
using Demo.Entities.Enums;

namespace Demo.Builder.Builders
{
    public class StudentAccountBuilder : BaseAccountBuilder<StudentAccount>, IStudentAccountBuilder
    {
        public void SetATMLimit(decimal atMLimit)
        {
            this._account.ATMLimit = atMLimit;
        }

        public void SetEnrolledInstitution(string enrolledInstitution)
        {
            this._account.EnrolledInstitution = enrolledInstitution;
        }

        public void SetHasParentalAccess(bool hasParentalAccess)
        {
            this._account.HasParentalAccess = hasParentalAccess;
        }

        public void SetLowBalanceAlert(decimal lowBalanceAlert)
        {
            this._account.LowBalanceAlert = lowBalanceAlert;
        }

        public void SetStudentStatus(StudentStatusType studentStatus)
        {
            this._account.StudentStatus = studentStatus;
        }
    }
}
