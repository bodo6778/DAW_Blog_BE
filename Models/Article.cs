﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DAW_Blog_BE.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(64, MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
