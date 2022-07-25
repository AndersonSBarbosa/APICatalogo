using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models
{
    [Table("Product")]
    public class Product : Base
    {
        [Required]
        [MaxLength(80)]
        public string ProductName { get; set; }
        [Required]
        [MaxLength(5000)]
        public string ProductDescription { get; set; }
        public int ColorId { get; set; }
        public int MaximumSizeId { get; set; }
        public int MinimimSizeId { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal DailyValue { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal PurchasePrice { get; set; }
        public Int64 ProductTypeId { get; set; }
        public ProductType? ProductType { get; set; }
    }
}
