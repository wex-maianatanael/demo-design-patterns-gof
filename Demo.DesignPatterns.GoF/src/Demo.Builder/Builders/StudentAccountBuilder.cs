using Demo.Builder.Builders.Contracts;
using Demo.Entities;
using Demo.Entities.Enums;

namespace Demo.Builder.Builders
{
    public class StudentAccountBuilder : BaseAccountBuilder<StudentAccount>, IStudentAccountBuilder
    {
        public void SetATMLimit(decimal atMLimit) => this._account.SetATMLimit(atMLimit);

        public void SetEnrolledInstitution(string enrolledInstitution) => this._account.SetEnrolledInstitution(enrolledInstitution);

        public void SetHasParentalAccess(bool hasParentalAccess) => this._account.SetHasParentalAccess(hasParentalAccess);

        public void SetLowBalanceAlert(decimal lowBalanceAlert) => this._account.SetLowBalanceAlert(lowBalanceAlert);

        public void SetStudentStatus(StudentStatusType studentStatus) => this._account.SetStudentStatus(studentStatus);
    }
}