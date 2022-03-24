using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }

        [Display(Name = "Profile Picture ")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]
        public string Bio { get; set; }
        //relationship
        public List<Movie> Movies{ get; set; }

}
}
