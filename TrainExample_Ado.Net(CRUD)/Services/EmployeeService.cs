using System.Data.SqlClient;
using TrainExample_Ado.Net_CRUD_.Interfaces;

namespace TrainExample_Ado.Net_CRUD_.Services
{
    public class EmployeeService : IEmployeeRepo
    {
        public  void EmployeeCreated()
        {
            using(SqlConnection connect=new SqlConnection())
            {
                string connectionString= $"Server = (localdb)\\MSSQLLocalDB; Database =Ishxona; Trusted_Connection = True;";
                connect.ConnectionString = connectionString ;
                connect.Open();

                string creatTableQuery=@"Create Table "
            }
        }

        public void EmployeeDeepDelete()
        {
            throw new NotImplementedException();
        }

        public void EmployeeDelete()
        {
            throw new NotImplementedException();
        }

        public void EmployeeUpdate()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById()
        {
            throw new NotImplementedException();
        }
    }
}
