using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        [Display(Name ="Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name ")]
        public string FullName { get; set; }
        public string Bio  { get; set; }
        // relationship
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
