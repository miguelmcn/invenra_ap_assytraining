using assytraining.application.Domain;

namespace assytraining.application.Interfaces.Services.Activities
{
    public interface IActivityDeploymentService
    {
        public Task<string> DeployActivity(Activity activity);
    }
}
