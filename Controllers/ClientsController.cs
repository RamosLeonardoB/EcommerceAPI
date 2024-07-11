using Microsoft.AspNetCore.Mvc;
using EcommerceAPI.Data;
using EcommerceAPI.Models;
using EcommerceAPI.DTOs;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Controllers
{
    [Route("clients")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public ClientsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> GetAll()
        {
            var clients = await _dbContext.Clients.ToListAsync();
            return Ok(clients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetById(int id)
        {
            var client = await _dbContext.Clients.FirstOrDefaultAsync(c => c.id == id);

            if (client == null)
            {
                return NotFound("Client not found.");
            }

            return Ok(client);

        }

        [HttpPost("get_by_email")]
        [Consumes("application/json")]
        public async Task<ActionResult<Client>> GetByEmail([FromBody] GetClientByEmailDTO client_to_search)
        {
            var client = await _dbContext.Clients.FirstOrDefaultAsync(c => c.email == client_to_search.email);

            if (client == null)
            {
                return NotFound("Client not found.");
            }

            return Ok(client);

        }

        [HttpPost]
        [Consumes("application/json")]
        public async Task<ActionResult<Client>> Create([FromBody] CreateClientDTO client_to_create)
        {

            var client = new Client
            {
                name = client_to_create.name,
                email = client_to_create.email,
                password = client_to_create.password,
                phone = client_to_create.phone,
                cpf_cnpj = client_to_create.cpf_cnpj,
                street = client_to_create.street,
                number = client_to_create.number,
                complement = client_to_create.complement,
                city = client_to_create.city,
                state = client_to_create.state,
                postal_code = client_to_create.postal_code,
                country = client_to_create.country,
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

            if (client == null)
            {
                return NotFound("Client not found");
            }

            client.name = !string.IsNullOrEmpty(client_to_update.name) ? client_to_update.name : client.name;
            client.phone = !string.IsNullOrEmpty(client_to_update.phone) ? client_to_update.phone : client.phone;
            client.password = !string.IsNullOrEmpty(client_to_update.password) ? client_to_update.password : client.password;
            client.street = !string.IsNullOrEmpty(client_to_update.street) ? client_to_update.street : client.street;
            client.number = !string.IsNullOrEmpty(client_to_update.number) ? client_to_update.number : client.number;
            client.complement = !string.IsNullOrEmpty(client_to_update.complement) ? client_to_update.complement : client.complement;
            client.city = !string.IsNullOrEmpty(client_to_update.city) ? client_to_update.city : client.city;
            client.state = !string.IsNullOrEmpty(client_to_update.state) ? client_to_update.state : client.state;
            client.postal_code = !string.IsNullOrEmpty(client_to_update.postal_code) ? client_to_update.postal_code : client.postal_code;
            client.country = !string.IsNullOrEmpty(client_to_update.country) ? client_to_update.country : client.country;

            await _dbContext.SaveChangesAsync();

            return Ok(client);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var client = await _dbContext.Clients.FirstOrDefaultAsync(c => c.id == id);

            if (client == null)
            {
                return NotFound("Client not found.");
            }

            _dbContext.Clients.Remove(client);

            await _dbContext.SaveChangesAsync();

            return Ok("Client deleted.");

        }

    }
}