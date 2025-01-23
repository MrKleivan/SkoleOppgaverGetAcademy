using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace RentalCars.API.Controllers;
[ApiController]
[Route("[controller]")]

public class RentalCarsController : ControllerBase
{
    
    
    private readonly string connectionString = "Server=KLEIVAN\\SQLEXPRESS;Database=RentalCars.dbo.InStock";
    
    // GET
    [HttpGet]
    public async Task GetCarById(int Id)
    {
        var conn = new SqlConnection(connectionString);
        const string sql = "SELECT * FROM InStock WHERE Id = @Id";
        var item = await conn;
        return item;
    }

    // [HttpGet]
    // public Task GetAllCars()
    // {
    //     var conn = new SqlConnection();
    // }
    
}