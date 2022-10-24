/*using DataAccesLayer;
using DataAccesLayer.Implementacion;
using DataAccesLayer.Interfaces;
using Dominio.Entidades;
using System.Data.SqlClient;

ISistema s = Fabrica.getInstance();

I_ManejadorPenca x = new ManejadorPenca();

x.agregar();*/

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
