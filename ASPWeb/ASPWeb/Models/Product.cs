using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ASPWeb.Models
{
    public class Product
    {

        public int Id { get; set; }

        public string Title { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        [JsonPropertyName("unit_price")]
        public float UnitPrice { get; set; }

        public float Discount { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
