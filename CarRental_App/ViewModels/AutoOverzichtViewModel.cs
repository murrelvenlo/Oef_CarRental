using CarRental_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental_App.ViewModels
{
    public class AutoOverzichtViewModel
    {
        public int AutoID { get; set; }
        public string MerkNaam { get; set; }
        public int Deuren { get; set; }
        public int Zitplaatsen { get; set; }
        public Decimal? Prijs { get; set; }
        public string Afbeelding { get; set; }
    }
}
