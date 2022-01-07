using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental_App.Models;

namespace CarRental_App.ViewModels
{
    public class DetailsKlantViewModel
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Emailadres { get; set; }
        public string Gemeente { get; set; }
        public string Postcode { get; set; }
        public string Straat { get; set; }
        public string Huisnummer { get; set; }
        public DateTime Geboortedatum { get; set; }
        public string Nationaliteit { get; set; }
    }
}
