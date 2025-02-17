using Fuelrecorder.Models;

namespace Fuelrecorder.Database;

public class FuelRecorderDb
{

    public async Task<List<FuelRecorder>> GetAll()
    {
        SqlConnect conn = new SqlConnect();

        await conn.OpenConnection();
    }
}