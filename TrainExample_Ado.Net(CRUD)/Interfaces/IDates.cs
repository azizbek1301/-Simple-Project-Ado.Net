namespace TrainExample_Ado.Net_CRUD_.Interfaces
{
    public interface IDates
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModiyDate { get; set; }
        public DateTime DelatedDate { get; set; }
    }
}
