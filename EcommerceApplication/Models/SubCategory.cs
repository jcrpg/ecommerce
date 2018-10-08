﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApplication.Models
{
    [Table("SubCategory")]
    public class SubCategory
    {

        public int SubCategoryId { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="Category Name")]
        public string SubCategoryName { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
