﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTraining.Models
{
    public class RestaurantReview
    {
        public int Id { get; set; }

        [Range(1, 10)]
        [Required]
        public int Rating { get; set; }

        [StringLength(1024)]
        [Required]
        public string Body { get; set; }
        public int RestaurantId { get; set; }
        public string ReviewerName { get; set; }
    }
}