using System.ComponentModel.DataAnnotations;

namespace CarShop.Models
{
    public partial class Car
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [MaxLength(100)]
        public string Preview { get; set; }
        [MaxLength(500)]
        public string SubPreview { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
    }
}