using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarRental_App.Models
{
    public class Automodel
    {
        public int AutomodelID { get; set; }
        public string Type { get; set; }
        public string Afbeelding { get; set; }
        public Merk merk { get; set; }
        public int MerkID { get; set; }
        

        public ICollection<Auto> Autos { get; set; }
    }
}
