using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceProduct.Models
{
    public class ExchangeRate
    {
        [Key]
        public Guid ExchangeRateId { get; set; }
        [ForeignKey("Currency")]
        public Guid CurrencyId { get; set; }
        [Required]
        [Display(Name ="Issue Date")]
        [DataType(DataType.Date)]
        public DateTime IssueDate { get; set; }
        [Required]
        public decimal Rate { get; set; }
        public Currency Currency { get; set; }
    }
}
