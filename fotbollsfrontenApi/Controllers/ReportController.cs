using FotbollsfrontenApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace FotbollsfrontenApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly ReportDbContext _context;

        public ReportController(ReportDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Report>>> GetReports()
        {
            return await _context.Reports.ToListAsync();
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<Report>> GetReport(int id)
        //{
        //    var report = await _context.Reports.FindAsync(id);

        //    if (report == null)
        //    {
        //        return NotFound();
        //    }

        //    return report;
        //}

    }
}
