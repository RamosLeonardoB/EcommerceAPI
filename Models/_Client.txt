namespace EcommerceAPI.Models
{
    public class Client
    {
        public int id { get; set; }
        public required string name { get; set; }
        public required string cpf_cnpj { get; set; }
        public required string? phone { get; set; }
        public required string email { get; set; }
        public required string password { get; set; }
        public required string street { get; set; }
        public required string number { get; set; }
        public required string? complement { get; set; }
        public required string city { get; set; }
        public required string state { get; set; }
        public required string postal_code { get; set; }
        public required string country { get; set; }
       
    }
}