using apicrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace apicrud.Controller
{
    [Route("api/[test]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly DatabaseHelper _db;
        public TestController(DatabaseHelper db){
            _db = db;
        }
        [HttpGet]
        public IActionResult TestDatabaseConnection()
        {
            string connectionMessage = _db.TestConnection();
            return Ok(connectionMessage);
        }
    }
}