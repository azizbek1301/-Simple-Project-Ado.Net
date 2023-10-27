using TrainExample_Ado.Net_CRUD_.EmployeeDto;
using TrainExample_Ado.Net_CRUD_.Enum;
using TrainExample_Ado.Net_CRUD_.Services;

EmployeeService employeeService = new EmployeeService();
Employeedto info=new Employeedto();
info.Name = "Azizbek";
info.Surname = "Rahmatullayev";
info.Email = "azizbek@gmail.com";
info.Login = "azizbek";
info.Password = "azizbek7";
info.Role=Role.Programmer;
//employeeService.EmployeeCreated();
//employeeService.InsertEmployee(info);
//employeeService.EmployeeDelete(2);
//employeeService.EmployeeUpdate(1,info);

//employeeService.EmployeeDeepDelete(2);

