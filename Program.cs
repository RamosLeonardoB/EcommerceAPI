using EcommerceAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);  //Criação do BUILD da aplicação
builder.Services.AddDbContext<AppDbContext>(options => 
  options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection")));

//builder.Services.AddScoped(typeof)

builder.Services.AddControllers();


var app = builder.Build(); // Construção do projeto

app.MapControllers();

app.Run();  // execução e inicalizção do projeto
