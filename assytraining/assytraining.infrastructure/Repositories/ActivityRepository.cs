using assytraining.application.Domain;
using assytraining.application.Interfaces.Repositories;
using assytraining.infrastructure.Repositories.Context;
using assytraining.infrastructure.Repositories.DataModel;

namespace assytraining.infrastructure.Repositories
{
    public class ActivityRepository<TDataModel> : IRepository<Activity>
        where TDataModel : class
    {
        public ActivityRepository()
        {
            ActivityContext.GetInstance();
        }

        public Task Delete(Activity domainModel)
        {
            var datamodel = new ActivityDataModel
            {
                ActivityID = domainModel.ActivityID
            };

            ActivityContext.GetInstance().Delete(datamodel);

            return Task.CompletedTask;
        }

        public Task<IEnumerable<Activity>> GetAll()
        {
            return Task.FromResult(ActivityContext.GetInstance().GetAll().Select(datamodel => new Activity
            {
                ActivityID = datamodel.ActivityID,
                IvenIRAStudentID = datamodel.IvenIRAStudentID,
                Params = datamodel.Params
            }
            ));
        }

        public Task<Activity> GetBy<TId>(TId id)
        {
            var datamodel = ActivityContext.GetInstance().GetBy(id);

            return Task.FromResult(new Activity
            {
                ActivityID = datamodel.ActivityID,
                IvenIRAStudentID = datamodel.IvenIRAStudentID,
                Params = datamodel.Params
            });
        }

        public async Task<Activity> Save(Activity domainModel)
        {
            var datamodel = new ActivityDataModel
            {
                ActivityID = domainModel.ActivityID,
                IvenIRAStudentID = domainModel.IvenIRAStudentID,
                Params = domainModel.Params
            };

            var saved = ActivityContext.GetInstance().Save(datamodel);

            return await GetBy(saved.ActivityID);
        }
    }
}
