namespace EcommerceAPI.DTOs
{
    public class CreateSellerDTO
    {
        public required string name { get; set; }
        public required string email { get; set; }
        public required string? phone { get; set; }
        public required string reference { get; set; }
        public required string password { get; set; }
    }

    public class UpdateSellerDTO
    {
        public required string? name { get; set; }
        public required string? phone { get; set; }
        public required string? password { get; set; }
    }

}