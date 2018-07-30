using System.ComponentModel.DataAnnotations;

namespace CarShop.Models
{
    public partial class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserEmail { get; set; }
        public int CarId { get; set; }
        [MaxLength(20)]
        public string Status { get; set; }
    }
}