using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental_App.Models;
using CarRental_App.ViewModels;

namespace CarRental_App.Controllers
{
    public class AutoController : Controller
    {
        

        public AutoController()
        {
            
        }

        
        public IActionResult AutoOverzicht()
        {
            List<Auto> autos = new List<Auto>();

            autos.Add(new Auto() { AutoID = 1, AutomodelID = 2, CategorieID = 1, Nummerplaat = "XX5H", Kleur = "Wit"});
            autos.Add(new Auto() { AutoID = 2, AutomodelID = 1, CategorieID = 2, Nummerplaat = "ZZK2", Kleur = "Zwart"});
            autos.Add(new Auto() { AutoID = 3, AutomodelID = 4, CategorieID = 3, Nummerplaat = "JkM5", Kleur = "Rood" });
            autos.Add(new Auto() { AutoID = 4, AutomodelID = 3, CategorieID = 4, Nummerplaat = "NY56N", Kleur = "Blauw" });
            autos.Add(new Auto() { AutoID = 5, AutomodelID = 6, CategorieID = 5, Nummerplaat = "LM56U", Kleur = "Grijs" });
            autos.Add(new Auto() { AutoID = 6, AutomodelID = 5, CategorieID = 6, Nummerplaat = "PU58K", Kleur = "Geel" });

            return View(autos);
        }

        



    }
}
