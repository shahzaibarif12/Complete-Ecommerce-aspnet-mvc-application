using eTickets.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        public string MovieName { get; set; }
        public string Description { get; set; }
        public Double  Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory  MovieCategory { get; set; }
        // public int MyProperty { get; set; }

        // Relationship
        public List<Actor_Movie> Actors_Movies { get; set; }

        // cinema
        public int CinemaId { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }


        // producer
        public int ProducerId { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

    }
}
