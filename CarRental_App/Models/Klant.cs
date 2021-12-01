using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarRental_App.Models
{
    public class Klant
    {
        public int KlantID { get; set; }
        [Required(ErrorMessage = "Het veld 'Naam' moet altijd ingevuld zijn.")]
        [MaxLength(10, ErrorMessage = "De maximum lengte van dit veld is 10 karakters")]
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public string Nationaliteit { get; set; }
        public string Telefoonnummer { get; set; }
        public string Emailadres { get; set; }
        public string Gemeente { get; set; }
        public string Postcode { get; set; }
        public string Straat { get; set; }
        public string Huisnummer { get; set; }

        public ICollection<Reservatie> Reservaties { get; set; }
    }
}
