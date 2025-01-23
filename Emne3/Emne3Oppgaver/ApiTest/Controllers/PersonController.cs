using ApiTest.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private Person[] _data = new[]
        {
            new Person() { Id = 1, Name = "John Doe", Email = "john.doe@gmail.com" },
            new Person() { Id = 2, Name = "Kalle", Email = "kalle@gmail.com" }
        };
        
        [HttpGet("{id}")]
        public async Task<Person?> GetOne(int id)
        {
            return await Task.Run( () => 
                _data.SingleOrDefault(p => p.Id == id));
        }

        [HttpGet]
        public async Task<IEnumerable<Person>> GetMeny()
        {
            return await Task.Run( () => _data);
        }

        [HttpPost]
        public async Task<int> Create(Person person)
        {
            return await Task.Run( () => 1 );
        }
        
        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            return await Task.Run( () => 1 );
        }
        
    }
}
