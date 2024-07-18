
namespace EcommerceAPI.Models
{
    public class Product
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string? image_url { get; set; }
        public int price { get; set; }
        public int stock { get; set; }
    }
}