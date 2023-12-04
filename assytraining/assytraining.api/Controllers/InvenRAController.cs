using assytraining.api.ViewModel;
using assytraining.application.Domain;
using assytraining.application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace assytraining.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvenRAController : Controller
    {
        InvenRAMockService _mockService;
        private readonly ILogger<InvenRAController> logger;

        private readonly IService<ApplicationParameterItem> _serviceAppParameterItem;

        public InvenRAController(InvenRAMockService mockService, ILogger<InvenRAController> _logger, IService<ApplicationParameterItem> serviceAppParameterItem)
        {
            _mockService = mockService;
            logger = _logger;
            _serviceAppParameterItem = serviceAppParameterItem;
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

        [HttpGet("/deploy-atividade/{activityID}")]
        public IActionResult DeployActivity(string activityID)
        {
            return Ok($"http://domain.com/atividade/" + activityID);
        }

        [HttpPost("/atividade/{activityID}")]
        public IActionResult StartActivity(string activityID, [FromBody] ActivityViewModel activity)
        {
            return Ok($"http://domain.com/execute-atividade/{activityID}");
        }

        [HttpPost("/execute-atividade/{activityID}/{studentId}")]
        public IActionResult ExecuteActivity(string activityID, string studentId)
        {
            return Ok($"http://domain.com/atividade/{activityID}");
        }

        [HttpGet("/json-params-atividade")]
        public IActionResult GetActivityParamListViewModel()
        {
            return Ok(_serviceAppParameterItem.GetAll().Select(u => new JsonParamItemViewModel
            {
                Name = u.Name,
                Type = u.Type,
            }));
        }
    }
}
