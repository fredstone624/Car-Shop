using CarShop.Models;
using System.Data.Entity;

namespace CarShop.DAL
{
    public class CarContext : DbContext
    {
        CarContext() : base("CarsConnection") { }

        public DbSet<Car> Cars { set; get; }
        public DbSet<Order> Orders { set; get; }
    }
}