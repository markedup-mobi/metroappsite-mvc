using System.Web.Mvc;

namespace MetroAppSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //[6]: Change this to reflect the title of your app
            ViewBag.Title = "MetroAppSite";

            return View();
        }

        public ActionResult Privacy()
        {
            //[6]: Change this to reflect the title of your app
            ViewBag.Title = "MetroAppSite - Privacy Policy";

            return View();
        }

        public ActionResult Download()
        {
            //[7]: Change this to the URL of your app on the Windows Store
            var AppDownloadUrl = "https://github.com/markedup-mobi/metroappsite-mvc";

            return RedirectPermanent(AppDownloadUrl);
        }

    }
}
