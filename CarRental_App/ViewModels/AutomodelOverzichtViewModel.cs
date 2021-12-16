using CarRental_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental_App.ViewModels
{
    public class AutomodelOverzichtViewModel
    {
        //public int AutomodelID { get; set; }
        //public string Type { get; set; }
        //public int MerkID { get; set; }
        //public string MerkNaam { get; set; }

        public List<Merk> Merken { get; set; }

    }
}
