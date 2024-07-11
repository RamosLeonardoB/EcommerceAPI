using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
}