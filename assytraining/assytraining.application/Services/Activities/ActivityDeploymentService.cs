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
            await activityService.Save(activity);

            var url = $"http://domain.com/atividade/" + activity.ActivityID;

            return url;
        }
    }
}
