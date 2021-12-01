using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental_App.Models
{
    [Table("ReservatieCategorieën")]
    public class ReservatieCategorie
    {
        public int ReservatieCategorieID { get; set; }

        public int ReservatieID { get; set; }
        public int CategorieID { get; set; }
    }
}
