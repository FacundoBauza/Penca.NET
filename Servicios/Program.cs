/*using DataAccesLayer;
using DataAccesLayer.Implementacion;
using DataAccesLayer.Interfaces;
using Dominio.Entidades;
using System.Data.SqlClient;

ISistema s = Fabrica.getInstance();

I_ManejadorPenca x = new ManejadorPenca();

x.agregar();*/

using BusinessLogic.Implementacion;
using BusinessLogic.Interfaces;
using DataAccesLayer.Implementacion;
using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SolutionContext>();

/********************************************************************************************************/
/** Add Dependencies                                                                                   **/
/********************************************************************************************************/
builder.Services.AddTransient<I_ManejadorTorneo, ManejadorTorneo>();
builder.Services.AddTransient<IB_Torneo, B_Torneo>();

builder.Services.AddTransient<I_ManejadorUsuario, ManejadorUsuario>();
builder.Services.AddTransient<IB_Usuario, B_Usuario>();

builder.Services.AddTransient<I_ManejadorPenca, ManejadorPenca>();
builder.Services.AddTransient<IB_Penca, B_Penca>();

builder.Services.AddTransient<I_ManejadorEvento, ManejadorEvento>();
builder.Services.AddTransient<IB_Evento, B_Evento>();

builder.Services.AddTransient<I_ManejadorPremio, ManejadorPremio>();
builder.Services.AddTransient<IB_Premio, B_Premio>();

builder.Services.AddTransient<I_ManejadorSubscripcion, ManejadorSubscripcion>();
builder.Services.AddTransient<IB_Subscripcion, B_Subscripcion>();

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

app.UseCors(builder =>
{
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});

app.Run();

