namespace APICatalogo.Models
{
    public class LocationItem : Base
    {
        public Guid LocationId { get; set; }
        public Guid ProductId { get; set; }
        public int Item { get; set; }
        public decimal Value { get; set; }
        public string OBS { get; set; }
    }
}
