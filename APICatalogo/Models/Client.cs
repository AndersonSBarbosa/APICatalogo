namespace APICatalogo.Models
{
    public class Client : Base
    {
        public string Name { get; set; }
        public DateOnly DateBirday { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string phone { get; set; }
    }
}
