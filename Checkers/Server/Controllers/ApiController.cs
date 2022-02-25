using Checkers.Server.Data;
using Checkers.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Checkers.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        private readonly TableManager _tableManager;

        public ApiController(TableManager tableManager)
        {
            _tableManager = tableManager;
        }

        [HttpGet("GetTables")]
        public IEnumerable<string> GetTables()
        {
            return _tableManager.Tables.Where(n => n.Value < 2).Select(n => n.Key);
        }
    }
}