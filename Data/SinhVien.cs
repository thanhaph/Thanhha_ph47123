using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class SinhVien
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "tên không được bỏ trống")]
        public string Name { get; set; }
        [Required]
        [Range(10, int.MaxValue, ErrorMessage = "tuổi phải lớn hơn 10")]
        public int Age { get; set; }
        [Required(ErrorMessage = "lớp không được bỏ trống")]
        public string Class { get; set; }
    }
}
