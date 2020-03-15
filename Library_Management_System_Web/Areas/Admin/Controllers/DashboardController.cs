using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library_Management_System_Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System_Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var model = new DashboardModel();
            return View();
        }
    }
}