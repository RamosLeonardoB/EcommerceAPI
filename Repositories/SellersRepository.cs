using EcommerceAPI.Data;
using EcommerceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Repositories
{
    public class SellersRepository
    {
        private readonly AppDbContext _dbContext;

        public SellersRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Seller>> GetAll()
        {
            return await _dbContext.Sellers.ToListAsync();
        }
        
    }
}