using Microsoft.AspNetCore.Mvc;
using EcommerceAPI.Data;
using EcommerceAPI.Models;
using EcommerceAPI.DTOs;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Controllers
{
    [Route("clientes")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public ClientsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> GetAll(){// getall retorna todos os client
            var clients = await _dbContext.Clients.ToListAsync();
            return Ok(clients);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetByID(int id)
        {
            var client = await _dbContext.Clients.FirstOrDefaultAsync(c => c.id == id);
            
            if (client == null){
                return NotFound("Client not found.");
            }

            return Ok(client);
        }


        [HttpPost]
        [Consumes("application/json")]
        public async Task<ActionResult<IEnumerable<Client>>> Create([FromBody] CreateClientDTO client_to_create ){

            var client = new Client
            {
                name = client_to_create.name,
                cpf_cnpj = client_to_create.cpf_cnpj,
                phone = client_to_create.phone,
                email = client_to_create.email,
                password = client_to_create.password,
                street = client_to_create.street,
                number = client_to_create.number,
                complement = client_to_create.complement,
                city = client_to_create.city,
                state = client_to_create.state,
                postal_code = client_to_create.postal_code,
                country = client_to_create.country
            };

            _dbContext.Clients.Add(client);

            await _dbContext.SaveChangesAsync();

            return Ok(client);

        }

        [HttpPut("{id}")]        
        [Consumes("application/json")]
        public async Task<ActionResult<Client>> Update(int id, [FromBody] UpdateClientDTO client_to_update)
        {
            var client = await _dbContext.Clients.FirstOrDefaultAsync(c => c.id == id);

            if (client  == null){
                return NotFound("Cliente not found");
            }

            client.name         = !string.IsNullOrEmpty(client_to_update.name)       ? client_to_update.name : client.name       ; 
            client.phone        = !string.IsNullOrEmpty(client_to_update.phone)      ? client_to_update.name : client.phone      ;
            client.password     = !string.IsNullOrEmpty(client_to_update.password)   ? client_to_update.name : client.password   ;
            client.street       = !string.IsNullOrEmpty(client_to_update.street)     ? client_to_update.name : client.street     ;
            client.number       = !string.IsNullOrEmpty(client_to_update.number)     ? client_to_update.name : client.number     ;
            client.complement   = !string.IsNullOrEmpty(client_to_update.complement) ? client_to_update.name : client.complement ;
            client.city         = !string.IsNullOrEmpty(client_to_update.city)       ? client_to_update.name : client.city       ;
            client.state        = !string.IsNullOrEmpty(client_to_update.state)      ? client_to_update.name : client.state      ;
            client.postal_code  = !string.IsNullOrEmpty(client_to_update.postal_code)? client_to_update.name : client.postal_code;
            client.country      = !string.IsNullOrEmpty(client_to_update.country)    ? client_to_update.name : client.country    ;

            await _dbContext.SaveChangesAsync();

            return Ok(client);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var client = await _dbContext.Clients.FirstOrDefaultAsync(c => c.id == id);

            if(client == null){
                return NotFound("Client not Found.");
            }


        }




    }
}