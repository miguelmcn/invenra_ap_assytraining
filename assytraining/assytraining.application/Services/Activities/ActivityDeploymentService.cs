using assytraining.application.Domain;
using assytraining.application.Interfaces.Services;
using assytraining.application.Interfaces.Services.Activities;

namespace assytraining.application.Services.Activities
{
    public class ActivityDeploymentService(IService<Activity> activityService) : IActivityDeploymentService
    {
        public async Task<string> DeployActivity(Activity activity)
        {
            // TODO: implement logic
            var createdActivity = await activityService.Save(activity);

            var url = $"http://domain.com/atividade/" + createdActivity.ActivityID;

            return url;
        }

        public async Task<string> DeployActivity(string activityId)
        {
            var activity = await activityService.GetBy(activityId);

            if (activity == null) { throw new Exception($"Activity {activityId} not found"); }

            return await DeployActivity(activity);
        }
    }
}
