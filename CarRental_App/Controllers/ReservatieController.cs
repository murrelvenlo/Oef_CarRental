using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental_App.Controllers
{
    public class ReservatieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
