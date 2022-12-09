using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Text.Json;
using System;

public class Estadistica
{
    [BsonId]
    public ObjectId Id { get; set; }
    public string Day { get; set; }
    public string Month { get; set; }
    public string Year { get; set; }
}
public class MongoDBRepository
{
    public MongoClient client;
    public IMongoDatabase db;
    public MongoDBRepository()
    {
        client = new MongoClient("mongodb://mongo:Yj0WrOCIj7n2KD08Bk3x@containers-us-west-156.railway.app:6569");
        db = client.GetDatabase("test");
    }
}

public interface IEstadisticas
{
    Task InsertLogin(Estadistica est);
    Task<List<Estadistica>> GetEstadisticas(string day, string month, string year);
}

public class EstadisticasCollection : IEstadisticas
{
    internal MongoDBRepository _repository = new MongoDBRepository();
    private IMongoCollection<Estadistica> Collection;

    public EstadisticasCollection()
    {
        Collection = _repository.db.GetCollection<Estadistica>("Estadisticas");
    }
    public async Task InsertLogin(Estadistica est)
    {
        await Collection.InsertOneAsync(est);
    }
    public async Task<List<Estadistica>> GetEstadisticas(string day, string month, string year)
    {
        return await Collection.FindAsync(new BsonDocument { { "Day", day }, { "Month", month }, { "Year", year } }).Result.ToListAsync();
    }

}
namespace Servicios.Controllers
{
    [Route("api/[controller]")]
    public class MongoController : Controller
    {
        private IEstadisticas db = new EstadisticasCollection();
        [HttpGet]
        public async Task<IActionResult> getAll(string day, string month, string year)
        {
            return Ok(await db.GetEstadisticas(day, month, year));
        }

        [HttpPost]
        public async Task<IActionResult> create([FromBody] Estadistica estadistica)
        {
            await db.InsertLogin(estadistica);
            return Created("Created", true);
        }
    }
}