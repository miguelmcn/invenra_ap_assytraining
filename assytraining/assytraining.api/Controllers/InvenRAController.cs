using assytraining.api.ViewModel;
using assytraining.application.Domain;
using assytraining.application.Interfaces.Services;
using assytraining.infrastructure.Infrastructure.Logging;
using Microsoft.AspNetCore.Mvc;

namespace assytraining.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvenRAController(InvenRAMockService mockService, ILogger<InvenRAController> logger, IService<ApplicationParameterItem> serviceAppParameterItem) : Controller
    {
        [HttpGet("/lista-analytics-atividade")]
        public IActionResult GetAnalyticsListViewModel()
        {
            return Ok(mockService.GetAnalyticsListViewModel());
        }

        [HttpPost("/analytics-atividade")]
        public IActionResult GetAnalyticsViewModel([FromBody] GetAnalyticsViewModel activityID)
        {
            return Ok(mockService.GetAnalyticsViewModel());
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
            APLogger.GetInstance().Log("AP::API::GET Param List");

            return Ok(serviceAppParameterItem.GetAll().Select(u => new JsonParamItemViewModel
            {
                Name = u.Name,
                Type = u.Type,
            }));
        }
    }
}
