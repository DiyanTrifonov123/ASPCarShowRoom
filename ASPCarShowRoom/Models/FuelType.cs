namespace ASPCarShowRoom.Models
{
    public class FuelType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RegisterOn { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
