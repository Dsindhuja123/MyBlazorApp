﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public int? Price { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        public List<OrderVM> Orders { get; set; }
    }
}
