using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "home/index";
        }

        public string About()
        {
            return "home/about";
        }
    }
}
