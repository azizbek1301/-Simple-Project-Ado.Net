using TrainExample_Ado.Net_CRUD_.EmployeeDto;

namespace TrainExample_Ado.Net_CRUD_.Interfaces
{
    public interface IEmployeeRepo
    {
        void EmployeeCreated();
        void EmployeeDelete(int EmployeeId);
        void EmployeeUpdate(int EmployeeId, Employeedto employee);
        void EmployeeDeepDelete();
        void GetAll();
        void GetById();
        void InsertEmployee(Employeedto employeedto);
    }
}
