using assytraining.api.ViewModel;
using assytraining.application.Domain;
using assytraining.application.Interfaces.Services;
using assytraining.application.Interfaces.Services.Activities;
using assytraining.infrastructure.Infrastructure.Logging;
using Microsoft.AspNetCore.Mvc;

namespace assytraining.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvenRAController(
        InvenRAMockService mockService,
        IService<ApplicationParameterItem> appConfigurationService,

        IService<AnalyticsConfiguration> analyticsConfigurationService,
        IAnalyticsReportService analyticsReportService,

        IActivityExecutionService activityExecutionService,
        IActivityCreatorService activityCreatorService,
        IActivityReaderService activityReaderService,
        IActivityDeploymentService activityDeploymentService

        ) : Controller
    {
        [HttpGet("/lista-analytics-atividade")]
        public async Task<IActionResult> GetAnalyticsListViewModel()
        {
            var domainmodel = await analyticsConfigurationService.GetBy(string.Empty);

            var viewmodel = new AnalyticsListViewModel
            {
                Qualitative = domainmodel?.Qualitative?.Select(u => new AnalyticsItemViewModel { Name = u.Name, Type = u.Type, Value = u.Value }),
                Quantitative = domainmodel?.Quantitative?.Select(u => new AnalyticsItemViewModel { Name = u.Name, Type = u.Type, Value = u.Value }),
            };

            return Ok(viewmodel);
        }

        [HttpPost("/analytics-atividade")]
        public async Task<IActionResult> GetAnalyticsViewModel([FromBody] GetAnalyticsViewModel activityID)
        {
            var domainmodel = await analyticsReportService.GetReport(activityID.ActivityID);

            var viewmodel = new AnalyticsViewModel
            {
                InvenIRAStudentID = domainmodel.InvenIRAStudentID,
                Qualitative = domainmodel?.Qualitative?.Select(u => new AnalyticsItemViewModel { Name = u.Name, Type = u.Type, Value = u.Value }),
                Quantitative = domainmodel?.Quantitative?.Select(u => new AnalyticsItemViewModel { Name = u.Name, Type = u.Type, Value = u.Value }),
            };

            return Ok(viewmodel);
        }

        [HttpPost("/deploy-atividade/")]
        public async Task<IActionResult> DeployActivity([FromBody] string activityID)
        {
            var deploymenturl = await activityDeploymentService.DeployActivity(activityID);

            return Ok(deploymenturl);
        }

        [HttpPost("/atividade/{activityID}")]
        public async Task<IActionResult> GoToActivity(string activityID, [FromBody] ActivityViewModel activityViewModel)
        {
            var newActivity = new Activity
            {
                ActivityID = activityViewModel.ActivityID,
                IvenIRAStudentID = activityViewModel.IvenIRAStudentID,
                Params = activityViewModel.Params
            };

            var activity = await activityCreatorService.CreateActivity(newActivity);

            return Ok($"http://domain.com/execute-atividade/{activity.ActivityID}");
        }

        [HttpPost("/execute-atividade/{activityID}/{studentId}")]
        public async Task<IActionResult> ExecuteActivity(string activityID, string studentId)
        {
            var activity = await activityReaderService.GetActivity(activityID);

            await activityExecutionService.Execute(activity, studentId);

            return Ok();
        }

        [HttpGet("/json-params-atividade")]
        public async Task<IActionResult> GetAPConfigurationViewModel()
        {
            return Ok((await appConfigurationService.GetAll()).Select(u => new JsonParamItemViewModel
            {
                Name = u.Name,
                Type = u.Type,
            }));
        }
    }
}
