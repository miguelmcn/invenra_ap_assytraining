using assytraining.application.Domain;
using assytraining.application.Interfaces.Repositories;
using assytraining.application.Interfaces.Services;
using assytraining.application.Interfaces.Services.Activities;

namespace assytraining.application.Services
{
    public class ActivityManagementService(IRepository<Activity> repository) : IService<Activity>
    {
        public Task<Activity> CreateActivityAsync(Activity activity)
        {
            return repository.Save(activity);
        }

        public Task DeployActivity(Activity activity)
        {
            // TODO: deployment process 

            return repository.Save(activity);
        }

        public Task<IEnumerable<Activity>> GetAll()
        {
            return repository.GetAll();
        }

        public Task<Activity> GetBy(string id)
        {
            return repository.GetBy(id);
        }

        public Task<Activity> Save(Activity domainModel)
        {
            return repository.Save(domainModel);
        }
    }
}
