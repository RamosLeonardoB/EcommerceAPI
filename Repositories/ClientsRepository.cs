
using EcommerceAPI.Data;
using EcommerceAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Repositories
{
    public class ClientsRepository
    {
        private readonly AppDbContext _dbContext;

        public ClientsRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Client>> GetAll()
        {
            
            return await _dbContext.Clients.ToListAsync();
            //return Ok(clients);

        }
    }
}