using CarShop.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace CarShop.DAL
{
    public class CarInitializer : DropCreateDatabaseIfModelChanges<CarContext>
    {
        protected override void Seed(CarContext context)
        {
            var cars = new List<Car>
            {
                new Car { Title = "Audi", Type = "Седан", Description = "Описание ауди", Preview = "/Content/img/cars/audi-itm.jpg",
                SubPreview = "/Content/img/cars/audi-itm.jpg,/Content/img/cars/audi-itm.jpg,/Content/img/cars/audi-itm.jpg",
                Count = 10, Price = 300000 },

                new Car { Title = "Audi", Type = "Седан", Description = "Описание ауди", Preview = "/Content/img/cars/audi-itm.jpg",
                SubPreview = "/Content/img/cars/audi-itm.jpg,/Content/img/cars/audi-itm.jpg,/Content/img/cars/audi-itm.jpg",
                Count = 10, Price = 300000 },

                new Car { Title = "Audi", Type = "Седан", Description = "Описание ауди", Preview = "/Content/img/cars/audi-itm.jpg",
                SubPreview = "/Content/img/cars/audi-itm.jpg,/Content/img/cars/audi-itm.jpg,/Content/img/cars/audi-itm.jpg",
                Count = 10, Price = 300000 }
            };

            cars.ForEach(c => context.Cars.Add(c));
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order { UserName = "Mark", UserEmail = "mark@mail.ru", CarId = 1,
                Status = "В обработке"},

                new Order { UserName = "Frank", UserEmail = "frank@mail.ru", CarId = 3,
                Status = "В обработке"},

                new Order { UserName = "Ros", UserEmail = "ros@mail.ru", CarId = 2,
                Status = "В обработке"}
            };

            orders.ForEach(o => context.Orders.Add(o));
            context.SaveChanges();
        }
    }
}