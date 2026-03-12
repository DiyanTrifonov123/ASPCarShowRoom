namespace ASPCarShowRoom.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeEquipmentId { get; set; }
        public TypeEquipment TypeEquipments { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime RegisterOn { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
