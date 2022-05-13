using AutoMapper;
using Pharma.API.Data;
using Pharma.API.Data.Interfaces;
using Pharma.API.Data.Repositories;
using Pharma.API.DTO;
using Pharma.API.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PharmaContext>();
builder.Services.AddScoped<IPharmaRepository, PharmaRepository>();


builder.Services.AddCors(options => {
    options.AddPolicy("CorsPolicy",
       builder => builder
       .WithOrigins("http://localhost:3000")
       .AllowAnyMethod()
       .AllowAnyHeader());
});

var config = new AutoMapper.MapperConfiguration(cfg =>
{
    cfg.CreateMap<PharmaModel, PharmaDTO>()
    .ForMember(dest => dest.PharmaId, opt => opt.MapFrom(x => x.PharmaId));
});
IMapper mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);
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