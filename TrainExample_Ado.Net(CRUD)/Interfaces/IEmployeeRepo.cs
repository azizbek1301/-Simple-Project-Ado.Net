namespace TrainExample_Ado.Net_CRUD_.Interfaces
{
    public interface IEmployeeRepo
    {
        public  void EmployeeCreated();
        public void EmployeeDelete();
        public void EmployeeUpdate();
        public void EmployeeDeepDelete();
        public void GetAll();
        public void GetById();
        public void InserEmployee();
    }
}
