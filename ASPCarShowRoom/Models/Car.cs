using Microsoft.VisualBasic.FileIO;

namespace ASPCarShowRoom.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string CarModel { get; set; }
        public string Description { get; set; }
        public string Year { get; set; }
        public int EquipmentId { get; set; }
        public Equipment Equipments { get; set; }
        public bool IsNew { get; set; }
        public int FuelTypeId { get; set; }
        public FuelType FuelTypes { get; set; }
        public int Power { get; set; }
        public int Acceleration { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public DateTime RegisterOn { get; set; }
        public ICollection<Cart> Carts { get; set; }
    }
}
