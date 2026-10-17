using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStores.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("~/TempView/Kanchan.cshtml");
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
