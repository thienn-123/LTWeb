using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiKiemTra03_03.Models
{
    public class Contract
    {
        [Key]
        public int contract_Id { get; set; }
        [Required]
        public string contract_Name { get; set; }
        [Required]
        public string signing_date { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        [Required]
        public Customer Customer { get; set; }
        [Required]
        public string contract_value { get; set; }

    }
}
