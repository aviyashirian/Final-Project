using System;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
