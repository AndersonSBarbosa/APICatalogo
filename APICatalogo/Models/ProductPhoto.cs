namespace APICatalogo.Models
{
    public class ProductPhoto : Base
    {
        public Guid ProductId { get; set; }
        public string Photo { get; set; }
        public bool Main { get; set; }
    }
}
