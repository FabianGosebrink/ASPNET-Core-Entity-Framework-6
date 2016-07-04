﻿using System.ComponentModel.DataAnnotations;

namespace AspnetCoreEF6Example.Models
{
    public class MyModelViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
