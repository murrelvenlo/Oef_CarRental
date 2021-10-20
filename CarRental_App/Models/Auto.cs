using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarRental_App.Models
{
    public class Auto
    {
        public int AutoID { get; set; }
        public Automodel automodel { get; set; } //eerst automodel aanmaken
        public int AutomodelID { get; set; }
        public Categorie categorie { get; set; }//eerst categorie aanmaken
        public int CategorieID { get; set; }
        public string Nummerplaat { get; set; }
        public string Kleur { get; set; }

    }
}
