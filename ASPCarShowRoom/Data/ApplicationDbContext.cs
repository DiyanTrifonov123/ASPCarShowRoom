using ASPCarShowRoom.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASPCarShowRoom.Data
{
    public class ApplicationDbContext : IdentityDbContext<Client>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<TypeEquipment> TypeEquipments { get; set; }
    }
}
