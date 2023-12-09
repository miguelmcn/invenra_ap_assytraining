using assytraining.application.Domain;
using assytraining.application.Interfaces.Services;
using assytraining.application.Interfaces.Services.Activities;

namespace assytraining.application.Services.Activities
{
    public class ActivityReaderService(IService<Activity> activityService) : IActivityReaderService
    {
        public Task<IEnumerable<Activity>> GetActivities()
        {
            // TODO: implement logic

            return activityService.GetAll();
        }

        public Task<Activity> GetActivity(string id)
        {
            // TODO: implement logic

            return activityService.GetBy(id);
        }
    }
}
