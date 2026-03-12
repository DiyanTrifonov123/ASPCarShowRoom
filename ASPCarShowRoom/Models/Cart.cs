namespace ASPCarShowRoom.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public Client Clients { get; set; }
        public int CarId { get; set; }
        public Car Cars { get; set; }
        public string Message { get; set; }
        public DateTime RegisterOn { get; set; }
    }
}
