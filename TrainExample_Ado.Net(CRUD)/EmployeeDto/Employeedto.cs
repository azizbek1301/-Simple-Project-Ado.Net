using TrainExample_Ado.Net_CRUD_.Enum;

namespace TrainExample_Ado.Net_CRUD_.EmployeeDto
{
    public class Employeedto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
