using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceProduct.Models
{
    public class ProductImage
    {
        [Key]
        public Guid ProductImageId { get; set; }
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public string Image { get; set; }
        public Product Product { get; set; }
    }
}
