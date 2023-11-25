using assytraining.api.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace assytraining.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvenRAController : Controller
    {
        InvenRAMockService _mockService;
        public InvenRAController(InvenRAMockService mockService)
        {
            _mockService = mockService;
        }

        [HttpGet("/lista-analytics-atividade")]
        public IActionResult GetAnalyticsListViewModel()
        {
            return Ok(_mockService.GetAnalyticsListViewModel());
        }

        [HttpPost("/analytics-atividade")]
        public IActionResult GetAnalyticsViewModel([FromBody] GetAnalyticsViewModel activityID)
        {
            return Ok(_mockService.GetAnalyticsViewModel());
        }

        [HttpPost("/atividade/{activityID}")]
        public IActionResult DeployActivity(string activityID, [FromBody] ActivityViewModel activity)
        {
            return Ok($"http://domain.com/path/{activityID}");
        }

        [HttpGet("/json-params-atividade")]
        public IActionResult GetActivityParamListViewModel()
        {
            return Ok(_mockService.GetJsonParamViewModel());
        }
    }
}
