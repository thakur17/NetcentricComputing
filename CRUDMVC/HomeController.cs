using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionCookieDemo.Models;

namespace SessionCookieDemo.Controllers
{
    public class HomeController : Controller
    {
       
        
        public IActionResult Index()
        {
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(1);
            options.IsEssential = true;
            options.Path = "/";

            HttpContext.Response.Cookies.Append("MyCookie", "Testing for cookie", options);


            HttpContext.Session.SetString("SessionKey", "Thakur");
            return View();
        }
        public IActionResult AboutUs()
        {
            ViewBag.Data=HttpContext.Session.GetString("SessionKey");
            return View();
        }
        public IActionResult Privacy()
        {
            ViewBag.Data = HttpContext.Session.GetString("SessionKey");
            return View();
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("SessionKey") != null)
            {
                HttpContext.Session.Remove("SessionKey");

            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
