using System.Linq;
using System.Web.Mvc;
using CarShop.DAL;

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
            string result = string.Empty;
            foreach(var car in cars)
            {
                result += string.Format("<li><a href='/Home/Car/?car_id={0}'>{1}</a></li>", car.Id, car.Title);
            }
            return Content(result);
        }
    }
}