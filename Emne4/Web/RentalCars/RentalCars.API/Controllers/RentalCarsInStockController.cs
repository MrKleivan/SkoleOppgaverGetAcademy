using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using RentalCars.API.Model;
namespace RentalCars.API.Controllers;

[ApiController]
[Route("[controller]")]
public class RentalCarsInStockController : ControllerBase
{
    private readonly string connectionString = "Server=KLEIVAN\\SQLEXPRESS;Database=RentalCars;Trusted_Connection=True;TrustServerCertificate=True";
    
    // GET
    [HttpGet]
    public async Task<IActionResult> GetAllCars()
    {
        const string sql = "SELECT * FROM InStock JOIN Cars ON InStock.CarId = Cars.Id";
        using (var conn = new SqlConnection(connectionString))
        {
            conn.Open();
            var cars = conn.Query<Car>(sql);
            return Ok(cars);
        }
        
    }
    [HttpGet("{Id}")]
    public async Task<IActionResult> GetCarById(int Id)
    {
        string sql = $"SELECT * FROM InStock JOIN Cars ON Cars.Id = CarId WHERE InStock.Id = {Id};";
        using (var conn = new SqlConnection(connectionString))
        {
            conn.Open();
            var cars = conn.Query<Car>(sql);
            return Ok(cars);
        }
        
    }
    
    [HttpPost]
    public async Task<IActionResult> AddCarToInStock()
    {
        const string sql = "INSERT INTO InStock (Id, CarId, Price, Available) VALUES ('4', '23', '450', 'Yes');";
        using (var conn = new SqlConnection(connectionString))
        {
            conn.Open();
            var cars = conn.Query<Car>(sql);
            return Ok(cars);
        }
    }
}