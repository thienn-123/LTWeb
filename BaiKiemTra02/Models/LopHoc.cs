using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra02.Models
{
    public class LopHoc
    {
        [Key]
        public int ID { get; set; }
        [Required (ErrorMessage ="Không được bỏ trống")]
        public string TenLopHoc { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống")]
        public DateTime NamNhapHoc { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống")]
        public DateTime NamRaTruong { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống")]
        public int SoLuongSinhVien { get; set; }
    }
}
