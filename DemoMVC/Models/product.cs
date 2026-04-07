using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(50, ErrorMessage = "Tên tối đa 50 ký tự")]
        public string Name { get; set; } = "";

        [Range(0, 1000000, ErrorMessage = "Giá phải >= 0")]
        public double Price { get; set; }
    }
}