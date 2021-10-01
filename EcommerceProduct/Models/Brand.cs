using System;
using System.ComponentModel.DataAnnotations;

namespace EcommerceProduct.Models
{
    public class Brand
    {
        [Key]
        public Guid BrandId { get; set; }
        [Required(ErrorMessage = "Brand Name field is required")]
        [MaxLength(50)]
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
    }
}
