using System;
using System.ComponentModel.DataAnnotations;

namespace EcommerceProduct.Models
{
    public class Currency
    {
        [Key]
        public Guid CurrencyId { get; set; }
        [Required(ErrorMessage = "Currency Name field is required")]
        [MaxLength(50)]
        [Display(Name = "Currency Name")]
        public string CategoryName { get; set; }
        [MaxLength(10)]
        public string Sign { get; set; }
    }
}
