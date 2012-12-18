using System.Web.Mvc;

namespace MetroAppSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "MetroAppSite";

            return View();
        }

        public ActionResult Privacy()
        {
            ViewBag.Title = "MetroAppSite - Privacy Policy";

            return View();
        }

        public ActionResult Download()
        {
            /*
                ToDo: change this URL to be equal to the URL of your app on the Windows Store
             */
            var AppDownloadUrl = "http://apps.microsoft.com/windows/en-US/app/relay/c7913da4-33ca-4642-8844-8bfa30c1e524";

            return RedirectPermanent(AppDownloadUrl);
        }

    }
}
