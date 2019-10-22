using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoggerService;
using Microsoft.AspNetCore.Mvc;

namespace GlobalErrorHandling.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ILoggerManager _logger;

        public ValuesController(ILoggerManager logger)
        {
            _logger = logger;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInfo("Fetching all the Students from the storage");

            var students = DataManager.GetAllStudents(); //simulation for the data base access

            _logger.LogInfo($"Returning {students.Count} students.");

            return Ok(students);
        }

        // Post api/values
        [HttpPost]
        public IActionResult Error()
        {
            throw new Exception("Exception while fetching all the students from the storage.");
        }
    }
}
