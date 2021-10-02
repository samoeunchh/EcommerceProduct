using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceProduct.Models
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        [Required]
        [MaxLength(100)]
        public string ShortDesciption { get; set; }
        [MaxLength(500)]
        public string LongDesciption { get; set; }
        public int Price { get; set; }
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        [ForeignKey("Currency")]
        public Guid CurrencyId { get; set; }
        [ForeignKey("Brand")]
        public Guid BrandId { get; set; }
        public string Code { get; set; }
        public int View { get; set; }
        public int QtyOnhand { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }
        public Currency Currency { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
