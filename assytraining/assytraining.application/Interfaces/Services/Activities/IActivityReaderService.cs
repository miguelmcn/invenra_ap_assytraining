using assytraining.application.Domain;

namespace assytraining.application.Interfaces.Services.Activities
{
    public interface IActivityReaderService
    {
        public Task<IEnumerable<Activity>> GetActivities();
        public Task<Activity> GetActivity(string id);
    }
}
