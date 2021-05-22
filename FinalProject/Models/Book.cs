using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public string Language { get; set; }

        public List<Genre> Genres { get; set; }

        public DateTime PublishedDate { get; set; }

        public int CopiesNum { get; set; }

        public double Price { get; set; }

        public string ImageUrl { get; set; }
    }
}
