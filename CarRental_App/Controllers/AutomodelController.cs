using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental_App.Models;
using CarRental_App.ViewModels;
using CarRental_App.Data;
using Microsoft.EntityFrameworkCore;


namespace CarRental_App.Controllers
{
    public class AutomodelController : Controller
    {
        private readonly CarRentalContext _context;

        public AutomodelController(CarRentalContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
