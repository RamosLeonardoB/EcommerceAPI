using Microsoft.AspNetCore.Mvc;
using EcommerceAPI.Data;
using EcommerceAPI.Models;
using EcommerceAPI.DTOs;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Controllers
{
    [Route("sellers")]
    [ApiController]
    public class SallersController : ControllerBase
    {
         private readonly AppDbContext _dbContext;

        public SallersController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }

}