using System.Web.Mvc;
using CarShop.DAL;

namespace CarShop.Controllers
{
    public class HomeController : Controller
    {
        private CarContext db = new CarContext();

        public ActionResult Index()
        {
            return View(db.Cars);
        }        
    }
}