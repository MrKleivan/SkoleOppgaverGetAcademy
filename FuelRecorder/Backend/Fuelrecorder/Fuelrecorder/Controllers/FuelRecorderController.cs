using Fuelrecorder.Database;
using Fuelrecorder.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fuelrecorder.Controllers;

[ApiController]
[Route("[controller]")]
public class FuelRecorderController : ControllerBase
{
    private readonly FuelrecorderDb _db;
    
    public FuelRecorderController(FuelrecorderDb db)
    {
        _db = db;
    }
    // GET
    [HttpGet, Authorize]
    public async Task<IResult> GetAllRecords() => await _db.GetAll();

    [HttpPost, Authorize]
    public async Task<IResult> AddNewRecord([FromBody] FuelRecorderModel newRecord) =>
        await _db.AddFuelRecord(newRecord);

    [HttpDelete("{id}"), Authorize]
    public async Task<IResult> DeleteRecord(int id) => 
        await _db.DeleteFuelRecord(id);
}