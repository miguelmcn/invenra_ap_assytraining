using assytraining.application.Domain;
using assytraining.application.Interfaces.Repositories;

namespace assytraining.application.Services
{
    public class ActivityManagementService(IRepository<Activity> repository) : BaseService<Activity>(repository)
    {
        public Task<Activity> CreateActivityAsync(Activity activity)
        {
            return Save(activity);
        }

        public Task DeployActivity(Activity activity)
        {
            // TODO: deployment process 

            return Save(activity);
        }

        public override Task<IEnumerable<Activity>> GetAll()
        {
            return repository.GetAll();
        }

        public override Task<Activity> GetBy(string id)
        {
            return repository.GetBy(id);
        }

        public override async Task Validate(Activity domainModel)
        {
            await Task.Run(() =>
            {
                if (string.IsNullOrEmpty(domainModel.ActivityID.Trim())) throw new Exception("Invalid Activity");
            });
        }
    }
}
