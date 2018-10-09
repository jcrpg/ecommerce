using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApplication.Models
{
    [Table("Product")]
    public class Product
    {

        public Product()
        {
            CartItems = new HashSet<CartItem>();
            OrderLines = new HashSet<OrderLine>();

        }
        public int ProductId { get; set; }
        [Required,Display(Name ="Product Name")]
        public string ProductName { get; set; }

        public string Detail { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        public int? UnitsInStock { get; set; }

        public byte[] ProductImagePath { get; set; }

        //public int CartId { get; set; }

        public int CategoryId { get; set; }

        //public int OrderLineId { get; set; }

        public int? PictureId { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }

        public virtual Category Category { get; set; }

        public ICollection<OrderLine> OrderLines { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }
    }
}
