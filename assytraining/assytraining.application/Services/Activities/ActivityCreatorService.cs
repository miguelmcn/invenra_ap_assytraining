using assytraining.application.Domain;
using assytraining.application.Interfaces.Services;
using assytraining.application.Interfaces.Services.Activities;

namespace assytraining.application.Services.Activities
{
    public class ActivityCreatorService(IService<Activity> activityService) : IActivityCreatorService
    {
        public Task<Activity> CreateActivity(Activity activity)
        {
            // TODO: implement logic

            return activityService.Save(activity);
        }
    }
}
