<<<<<<< HEAD
namespace EcommerceAPI.Models
{
    public class Seller
    {
        public int id { get; set; }
        public string name { get; set; }
        public string reference { get; set; }
        public string? phone { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
=======
namespace EcommerceAPI.Models
{
    public class Seller
    {
        public int id { get; set; }
        public required string name { get; set; }
        public required string reference { get; set; }
        public required string phone { get; set; }
        public required string email { get; set; }
        public required string password { get; set; }
    }
>>>>>>> 3c61527c79e0a638a30682c4a562eb3e43753a66
}