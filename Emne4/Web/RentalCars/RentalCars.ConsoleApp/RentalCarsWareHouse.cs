using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace RentalCars.ConsoleApp;
using RentalCars.API.Controllers;

public class RentalCarsWareHouse
{
    public List<Car> Cars { get; set; }

    public RentalCarsWareHouse()
    {
    }

    public async Task<List<Car>> CreateListOfCars()
    {
        var baseUrl = "https://localhost:7146/RentalCarsInStock";
        var hei = new RentalCarsInStockController().GetAllCars();
        var client = new HttpClient();
        var cars = new List<Car>();
        var response = await client.GetAsync($"{baseUrl}/api/Cars");
        Console.WriteLine(hei);
        return cars;
    }


    public void Run()
    {
        CreateListOfCars();
    }
}