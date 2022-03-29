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
        [Required(ErrorMessage ="Profile Picture is Required")]
        public string ProfilePictureURL { get; set; }


        [Display(Name = "Full Name ")]
        [Required(ErrorMessage = "Full Name is Required")]
        [StringLength(50,MinimumLength = 3,ErrorMessage ="Full Name Must be between 3 and 50 character Required")]
        public string FullName { get; set; }

        [Display(Name = "Biography ")]
        [Required(ErrorMessage = "Biography is Required")]
        public string Bio  { get; set; }
        // relationship
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
