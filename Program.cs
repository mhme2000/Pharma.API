using AutoMapper;
using Pharma.API.Data;
using Pharma.API.Data.Interfaces;
using Pharma.API.Data.Repositories;
using Pharma.API.DTO;
using Pharma.API.Model;
using Pharma.API.Services;
using Pharma.API.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PharmaContext>();
builder.Services.AddScoped<IPharmaRepository, PharmaRepository>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IStockRepository, StockRepository>();
builder.Services.AddScoped<IStockItemRepository, StockItemRepository>();
builder.Services.AddScoped<IStockTransactionRepository, StockTransactionRepository>();
builder.Services.AddScoped<IStockTransactionItemRepository, StockTransactionItemRepository>();
builder.Services.AddScoped<IOrdersService, OrdersService>();


builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
       builder => builder
       .WithOrigins("http://localhost:3001")
       .AllowAnyMethod()
       .AllowAnyHeader());
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
var app = builder.Build();

app.UseCors("CorsPolicy");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();