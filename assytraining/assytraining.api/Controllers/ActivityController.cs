using assytraining.api.ViewModel;
using assytraining.application.Domain;
using assytraining.application.Interfaces.Services.Activities;
using Microsoft.AspNetCore.Mvc;

namespace assytraining.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActivityController(
        IActivityExecutionService activityExecutionService,
        IActivityCreatorService activityCreatorService,
        IActivityReaderService activityReaderService,
        IActivityDeploymentService activityDeploymentService
    ) : Controller
    {
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
    }
}
