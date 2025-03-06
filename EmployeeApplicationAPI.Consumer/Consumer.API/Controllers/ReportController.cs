using Consumer.Database;
using Consumer.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Consumer.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController(EmployeeReportDbContext dbContext, ILogger<ReportController> logger) : ControllerBase
    {
        private readonly ILogger<ReportController> _logger = logger;
        private readonly EmployeeReportDbContext _dbContext = dbContext;

        [HttpGet]
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            _logger.LogInformation("Getting employees");
            return await _dbContext.Reports.Select(x => new Employee(
                x.EmployeeId,
                x.Name,
                x.Surname
            )).ToListAsync();
        }
    }
}
