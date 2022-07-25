namespace APICatalogo.Models
{
    public class Location : Base
    {
        public Guid ClienteId { get; set; }
        public Guid UsersId { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public DateTime DateWithdrawn { get; set; }
        public DateTime DateDelivery { get; set; }
        public string OBS { get; set; }

    }
}
