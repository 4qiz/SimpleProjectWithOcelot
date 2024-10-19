using System.Text.Json.Serialization;

namespace OrdersApi.Models
{
    public class OrderItem
    {
        [JsonIgnore]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        [JsonIgnore]
        public int OrderId { get; set; }
        [JsonIgnore]
        public Order Order { get; set; } = null!;
    }
}