namespace EcommerceAPI.DTOs
{
    public class CreateProductDTO
    {
        public required string title { get; set; }
        public required string description { get; set; }
        public required string? image_url { get; set; }
        public required int price { get; set; }
        public required int stock { get; set; }
    }
}