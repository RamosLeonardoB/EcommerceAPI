namespace EcommerceAPI.DTOs
{
    public class CreateClientDTO
    {
        public string name { get; set; }
        public string cpf_cnpj { get; set; }
        public string? phone { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string street { get; set; }
        public string number { get; set; }
        public string? complement { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postal_code { get; set; }
        public string country { get; set; }
    }

    public class UpdateClientDTO
    {
        public string? name { get; set; }
        public string? phone { get; set; }
        public string? password { get; set; }
        public string? street { get; set; }
        public string? number { get; set; }
        public string? complement { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public string? postal_code { get; set; }
        public string? country { get; set; }
    }

    public class GetClientByEmailDTO
    {
        public string email { get; set; }
    }

}