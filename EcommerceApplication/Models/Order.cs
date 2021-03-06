﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApplication.Models
{
    [Table("Order")]
    public class Order
    {

        public Order()
        {
            OrderLines = new HashSet<OrderLine>();
        }

        public int OrderId { get; set; }

        public DateTime? OrderDate { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public decimal OrderTotal { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customers { get; set; }

        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
