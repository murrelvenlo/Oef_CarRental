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
    public class MerkController : Controller
    {
        private readonly CarRentalContext _context;

        public MerkController(CarRentalContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            AutomodelOverzichtViewModel vm = new AutomodelOverzichtViewModel();
            vm.Merken = await _context.Merken.ToListAsync();
            return View(vm);
        }
    }
}
