using System;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public double Lontitude { get; set; }

        public double Latitude { get; set; }

        public string OpeningHour { get; set; }

        public string ClosingHour { get; set; }
    }
}
