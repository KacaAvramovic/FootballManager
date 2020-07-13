using Microsoft.AspNetCore.Mvc;
using FootballManager.Service.Contract;
using System.Threading.Tasks;

namespace FootballManager.Controllers
{
    [Route("api/Report")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            this._reportService = reportService;
        }

        [HttpGet]
        public async Task<IActionResult> GetReport()
        {
            await _reportService.GetReport();
            return Ok();
        }

    }
}