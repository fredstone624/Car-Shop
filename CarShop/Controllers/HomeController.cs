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
            ViewBag.Title = car.Title;
            return View(car);
        }
    }
}