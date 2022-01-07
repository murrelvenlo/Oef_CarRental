using CarRental_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental_App.ViewModels
{
    public class AutoLijstViewModels
    {
       // public int AutoID { get; set; }
       //// public Automodel automodel { get; set; } //eerst automodel aanmaken
       // public int AutomodelID { get; set; }
       //// public Categorie categorie { get; set; }//eerst categorie aanmaken
       // public int CategorieID { get; set; }
       // public string Nummerplaat { get; set; }
       // public string Kleur { get; set; }

        public List<Auto> Autos { get; set; }
        public string AutoZoeken { get; set; }
    }
}
