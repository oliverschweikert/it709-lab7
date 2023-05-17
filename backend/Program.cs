using backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<Lab7Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Lab7Context") ?? throw new InvalidOperationException("Connection string 'Lab7Context' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(options =>
options.WithOrigins("http://localhost:3000")
.AllowAnyHeader()
.AllowAnyMethod());

app.UseAuthorization();

app.MapControllers();

app.Run();
