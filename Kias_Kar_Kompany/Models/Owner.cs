using System.ComponentModel.DataAnnotations;

namespace Kias_Kar_Kompany.Models
{
    public class Owner
    {
        [Key]
        public int OwnerId { get; set; }
        public required string OwnerName { get; set; }

        public string? OwnerEmail { get; set; }

        public int PhoneNumber { get; set; }

        public List<Vehicle>? Vehicles { get; set; }
    }
}
