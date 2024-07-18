using Microsoft.AspNetCore.Mvc;
using EcommerceAPI.Data;
using EcommerceAPI.Models;
using EcommerceAPI.DTOs;
using Microsoft.EntityFrameworkCore;
using EcommerceAPI.Repositories;

namespace EcommerceAPI.Controllers
{

    [Route("sellers")]
    [ApiController]
    public class SellersController : ControllerBase
    {
        //private readonly AppDbContext _dbContext; // troca pela linha abaixo

        private readonly SellersRepository _repository;

        public SellersController(SellersRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Seller>>> GetAll()
        {
            var sellers = await _repository.GetAll();
            return Ok(sellers);
        }


/*
        [HttpGet("{id}")]
        public async Task<ActionResult<Seller>> GetById(int id)
        {
            var seller = await _dbContext.Sellers.FirstOrDefaultAsync(s => s.id == id);

            if (seller == null)
            {
                return NotFound("Seller not found.");
            }

            return Ok(seller);

        }

        [HttpPost("{name}")]
        public async Task<ActionResult<IEnumerable<Seller>>> GetByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return BadRequest("Nome inválido.");
            }

            var sellers = await _dbContext.Sellers.Where(s => s.name.Contains(name)).ToListAsync();

            if (sellers.Count == 0)
            {
                return NotFound("Vendedores não encontrados.");
            }

            return Ok(sellers);
        }


        [HttpPost]
        [Consumes("application/json")]
        public async Task<ActionResult<Seller>> Create([FromBody] CreateSellerDTO seller_to_create)
        {

            var seller = new Seller
            {
                name = seller_to_create.name,
                email = seller_to_create.email,
                password = seller_to_create.password,
                phone = !string.IsNullOrEmpty(seller_to_create.phone) ? seller_to_create.phone : null,
                reference = seller_to_create.reference
            };

            _dbContext.Sellers.Add(seller);

            await _dbContext.SaveChangesAsync();

            return Ok(seller);
        }

        [HttpPut("{id}")]
        [Consumes("application/json")]
        public async Task<ActionResult<Seller>> Update(int id, [FromBody] UpdateSellerDTO seller_to_update)
        {
            var seller = await _dbContext.Sellers.FirstOrDefaultAsync(s => s.id == id);

            if (seller == null)
            {
                return NotFound("Seller not found");
            }

            seller.name = !string.IsNullOrEmpty(seller_to_update.name) ? seller_to_update.name : seller.name;
            seller.phone = !string.IsNullOrEmpty(seller_to_update.phone) ? seller_to_update.phone : seller.phone;
            seller.password = !string.IsNullOrEmpty(seller_to_update.password) ? seller_to_update.password : seller.password;

            await _dbContext.SaveChangesAsync();

            return Ok(seller);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var seller = await _dbContext.Sellers.FirstOrDefaultAsync(s => s.id == id);

            if (seller == null)
            {
                return NotFound("Seller not found.");
            }

            _dbContext.Sellers.Remove(seller);

            await _dbContext.SaveChangesAsync();

            return Ok("Seller deleted.");

        }
        */

    }

}