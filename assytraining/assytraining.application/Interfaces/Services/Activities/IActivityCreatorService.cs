using assytraining.application.Domain;

namespace assytraining.application.Interfaces.Services.Activities
{
    public interface IActivityCreatorService
    {
        public Task<Activity> CreateActivity(Activity activity);
    }
}
