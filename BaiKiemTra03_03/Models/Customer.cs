using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra03_03.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        public string? Email { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}
