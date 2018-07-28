namespace CarShop.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public int CarId { get; set; }
        public string Status { get; set; }
    }
}