using TrainExample_Ado.Net_CRUD_.Enum;
using TrainExample_Ado.Net_CRUD_.Interfaces;

namespace TrainExample_Ado.Net_CRUD_.Model
{
    public class Employee:IDates
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname {  get; set; }
        public string Email {  get; set; }
        public string Login {  get; set; }
        public string Password {  get; set; }
        public Status Status { get; set; }
        public Role Role { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModiyDate { get; set; }
        public DateTime DelatedDate { get; set; }
    }
}
