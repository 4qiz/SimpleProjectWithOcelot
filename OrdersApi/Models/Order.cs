﻿namespace OrdersApi.Models
{
    public class Order
    {
        public int OrderId {get; set; }
        public List<OrderItem> Items { get; set; } = [];
    }
}
