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

                string creatTableQuery = @"CREATE TABLE Xodim (
                                        Id  int IDENTITY(1,1),
                                        Name varchar(255),
                                        Surname varchar(255),
                                        Email varchar(255),
                                        Login varchar(255),
                                        Password VARCHAR(50),
                                        Status VARCHAR(50),
                                        Role VARCHAR(50),
                                        CreatedDate DATETIME DEFAULT GETDATE(),
                                        ModifyDate Text DEFAULT NULL,
                                        DeletedDate Text DEFAULT NULL
                                    );";

                SqlCommand cmd=new SqlCommand(creatTableQuery,connect);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Succesfully table created");
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

        public void InserEmployee()
        {
            throw new NotImplementedException();
        }
    }
}
