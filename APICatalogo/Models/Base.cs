using System.ComponentModel.DataAnnotations;

namespace APICatalogo.Models
{
    public class Base
    {
        [Key]
        public Int64 Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int StatusId { get; set; }
        public Boolean IsActive { get; set; }
    }
}
