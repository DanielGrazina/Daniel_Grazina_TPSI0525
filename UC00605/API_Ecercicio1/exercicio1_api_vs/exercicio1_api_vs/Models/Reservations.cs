namespace exercicio1_api_vs.Models
{
    public class Reservations
    {
        public int Id { get; set; }
        public string Cliente { get; set; } = "";
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
    }
}
