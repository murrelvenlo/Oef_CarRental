﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental_App.Models
{
    public class Reservatie
    {
        public int ReservatieID { get; set; }
        public Klant klant { get; set; }// eerst klant aanmaken
        public int KlantID { get; set; }
        [Display(Name = "Ophaaldatum")]
        public DateTime Ophaaldatum { get; set; }
        [Display(Name = "Afleverdatum")]
        public DateTime Afleverdatum { get; set; }
        public string Status { get; set; }
        public string Betaalmethode { get; set; }

        public ICollection<ReservatieCategorie> ReservatieCategorieën { get; set; }
    }
}
