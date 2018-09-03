using System.Linq;
using System.Web.Mvc;
using CarShop.DAL;
using CarShop.Models;

namespace CarShop.Controllers
{
    public class HomeController : Controller
    {
        private CarContext db = new CarContext();

        public ActionResult Index()
        {
            ViewBag.Title = "Главная";
            return View(db.Cars);
        }
        
        public ActionResult Car(int car_id)
        {
            var car = db.Cars.FirstOrDefault(c => c.Id == car_id);
            if (car == null)
                return Content("Автомобиль не найден!");
            ViewBag.Title = car.Title;
            return View(car);
        }

        [ChildActionOnly]
        public ActionResult Nav()
        {
            var cars = db.Cars;
            string result = "";
            foreach(var car in cars)
            {
                result += string.Format("<li><a href='/Home/Car/?car_id={0}'>{1}</a></li>", car.Id, car.Title);
            }
            return Content(result);
        }

        [HttpGet]
        public ActionResult Form(int car_id = 0)
        {
            ViewBag.Car = car_id;
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult FormOptions(int car_id = 0)
        {
            var cars = db.Cars;
            string options = "";
            foreach (var car in cars)
            {
                if (car.Id == car_id)
                    options += string.Format("<option value='{0}' selected>{1}</option>", car.Id, car.Title);
                else
                    options += string.Format("<option value='{0}'>{1}</option>", car.Id, car.Title);

            }
            return Content(options);
        }

        [HttpPost]
        public ActionResult Form(string userName, string userEmail, int carId)
        {
            var order = new Order
            {
                UserName = userName,
                UserEmail = userEmail,
                CarId = carId,
                Status = "Создана"
            };

            db.Orders.Add(order);
            db.SaveChanges();

            return Content(string.Format("{0}, ваша заявка на автомобиль {1}, была принята!", userName, db.Cars.FirstOrDefault(c => c.Id == carId).Title));
        }
    }
}