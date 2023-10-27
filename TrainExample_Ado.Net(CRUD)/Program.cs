using TrainExample_Ado.Net_CRUD_.EmployeeDto;
using TrainExample_Ado.Net_CRUD_.Enum;
using TrainExample_Ado.Net_CRUD_.Services;

EmployeeService employeeService = new EmployeeService();
Employeedto info=new Employeedto();
info.Name = "Ali";
info.Surname = "Valiyev";
info.Email = "ali@gmail.com";
info.Login = "alivali";
info.Password = "ali7";
info.Role=Role.Admin;
//employeeService.EmployeeCreated();
employeeService.InsertEmployee(info);

