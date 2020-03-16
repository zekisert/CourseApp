using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class CourseController : Controller
    {
        public string Index()
        {
            return "Course/Index";
        }

        public string List()
        {
            return "Course/List";
        }
    }
}
