using Microsoft.AspNetCore.Identity;

namespace ASPCarShowRoom.Models
{
    public class Client : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime RegisterOn { get; set; }
        public ICollection<Cart> Carts { get; set; }
    }
}
