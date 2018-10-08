﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApplication.Models
{
    [Table("Customer")]
    public class Customer
    {
        public Customer()
        {
            CartItems = new HashSet<CartItem>();

            Orders = new HashSet<Order>();
        }
        [ScaffoldColumn(false)]
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }

        public string LastName { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }
        [DataType(DataType.PostalCode)]
        public int PostalCode { get; set; }
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        public DateTime? DateEntred { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
