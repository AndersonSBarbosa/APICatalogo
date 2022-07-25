using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models
{
    [Table("ProductType")]
    public class ProductType : Base
    {
        public ProductType()
        {
            Products = new Collection<Product>();
        }
        [Required]
        [MaxLength(80)]
        public string? ProductTypeName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
