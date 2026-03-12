namespace ASPCarShowRoom.Models
{
    public class TypeEquipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RegisterOn { get; set; }
        public ICollection<Equipment> Equipments { get; set; }
    }
}
