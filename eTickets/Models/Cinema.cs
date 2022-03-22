﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int ProducerId { get; set; }
        public string logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}