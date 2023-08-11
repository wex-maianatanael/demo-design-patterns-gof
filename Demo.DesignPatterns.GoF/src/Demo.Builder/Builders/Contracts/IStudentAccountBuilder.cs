using Demo.Entities;
using Demo.Entities.Enums;

namespace Demo.Builder.Builders.Contracts
{
    public interface IStudentAccountBuilder : IBaseAccountBuilder<StudentAccount>
    {
        void SetStudentStatus(StudentStatusType studentStatus);

        void SetEnrolledInstitution(string enrolledInstitution);

        void SetLowBalanceAlert(decimal lowBalanceAlert);

        void SetHasParentalAccess(bool hasParentalAccess);

        void SetATMLimit(decimal atMLimit);
    }
}