using eTickets.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public Double  Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory  MovieCategory { get; set; }
       // public int MyProperty { get; set; }

    }
}
