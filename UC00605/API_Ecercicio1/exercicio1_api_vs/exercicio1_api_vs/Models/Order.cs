namespace exercicio1_api_vs.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Estado { get; set; } = "";
    }
}
