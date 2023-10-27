using System.Data.SqlClient;
using TrainExample_Ado.Net_CRUD_.EmployeeDto;
using TrainExample_Ado.Net_CRUD_.Enum;
using TrainExample_Ado.Net_CRUD_.Interfaces;
using TrainExample_Ado.Net_CRUD_.Model;

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

        public void EmployeeDelete(int EmployeeId)
        {
            using (SqlConnection connect = new SqlConnection())
            {
                string connectionString = $"Server = (localdb)\\MSSQLLocalDB; Database =Ishxona; Trusted_Connection = True;";
                connect.ConnectionString = connectionString;
                connect.Open();
                string query = $"Update Xodim set Status='{Status.Deleted}',Deleteddate='{DateTime.UtcNow}' where Id={EmployeeId} and Status <> 'Deleted';";
                SqlCommand command=new SqlCommand(query,connect);
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("O'chirildi");
                }
                
                
            }
        }

        public void EmployeeUpdate(int EmployeeId,Employeedto employee)
        {
            using (SqlConnection connect = new SqlConnection())
            {
                string connectionString = $"Server = (localdb)\\MSSQLLocalDB; Database =Ishxona; Trusted_Connection = True;";
                connect.ConnectionString = connectionString;
                connect.Open();
                string query = $"Update Xodim set Name='{employee.Name}',Surname='{employee.Surname}',Email='{employee.Email}',Login='{employee.Login}',Password='{employee.Password}',Status='{Status.Updated}',Role='{employee.Role}',ModifyDate='{DateTime.Now}' where Id={EmployeeId} and Status <> 'Deleted';";

                SqlCommand command = new SqlCommand(query, connect);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Updated");
                }
            }
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById()
        {
            throw new NotImplementedException();
        }

        public void InsertEmployee(Employeedto employeedto)
        {

            using (SqlConnection connect = new SqlConnection())
            {
                string connectionString = $"Server = (localdb)\\MSSQLLocalDB; Database =Ishxona; Trusted_Connection = True;";
                connect.ConnectionString = connectionString;
                connect.Open();

                string creatTableQuery = $"INSERT INTO Xodim(Name,Surname,Email,Login,Password,Status,Role)" +
                    $"VALUES('{employeedto.Name}','{employeedto.Surname}','{employeedto.Email}','{employeedto.Login}','{employeedto.Password}','{Status.Created}','{employeedto.Role}')";

                SqlCommand cmd = new SqlCommand(creatTableQuery, connect);

                try
                {
                    using(SqlDataReader reader=cmd.ExecuteReader())
                    {

                    }
                     Console.WriteLine("Insert Data in Table");

                }
                catch
                {
                    Console.WriteLine("Bu ma'lumot avvaldan bor");
                }
                
            }
        }
    }
}
