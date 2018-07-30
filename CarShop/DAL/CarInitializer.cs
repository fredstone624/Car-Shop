using System.Collections.Generic;
using System.Data.Entity;
using CarShop.Models;

namespace CarShop.DAL
{
    public class CarInitializer : DropCreateDatabaseIfModelChanges<CarContext>
    {
        protected override void Seed(CarContext context)
        {
            var cars = new List<Car>
            {
                new Car
                {
                    Title ="Audi", Type="Седан", Description="Описание ауди",
                    Preview = "/Content/img/cars/audi.jpg",
                    SubPreview = "/Content/img/cars/audi-1.jpg,/Content/img/cars/audi-2.jpg,/Content/img/cars/audi-3.jpg",
                    Count = 10, Price = 2000000
                },
                new Car
                {
                    Title ="Audi-2", Type="Long", Description="Description-2",
                    Preview = "/Content/img/cars/audi.jpg",
                    SubPreview = "/Content/img/cars/audi.jpg,/Content/img/cars/audi.jpg,/Content/img/cars/audi.jpg",
                    Count = 2, Price = 100000
                },
                new Car
                {
                    Title ="Audi-3", Type="Short", Description="Description-3",
                    Preview = "/Content/img/cars/audi.jpg",
                    SubPreview = "/Content/img/cars/audi.jpg,/Content/img/cars/audi.jpg,/Content/img/cars/audi.jpg",
                    Count = 50, Price = 500000
                }
            };

            cars.ForEach(c => context.Cars.Add(c));
            context.SaveChanges();
        }
    }
}