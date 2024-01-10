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

        public async Task<IEnumerable<Activity>> GetAll()
        {
            return (await ActivityContext.GetInstance().GetAll()).Select(datamodel => new Activity
            {
                ActivityID = datamodel.ActivityID,
                IvenIRAStudentID = datamodel.IvenIRAStudentID,
                Params = datamodel.Params
            });
        }

        public async Task<Activity> GetBy<TId>(TId id)
        {
            var datamodel = await ActivityContext.GetInstance().GetBy(id);

            return new Activity
            {
                ActivityID = datamodel.ActivityID,
                IvenIRAStudentID = datamodel.IvenIRAStudentID,
                Params = datamodel.Params
            };
        }

        public async Task<Activity> Save(Activity domainModel)
        {
            var datamodel = new ActivityDataModel
            {
                ActivityID = domainModel.ActivityID,
                IvenIRAStudentID = domainModel.IvenIRAStudentID,
                Params = domainModel.Params
            };

            var saved = await ActivityContext.GetInstance().Save(datamodel);

            return new Activity
            {
                ActivityID = saved.ActivityID,
                IvenIRAStudentID = saved.IvenIRAStudentID,
                Params = saved.Params
            };
        }
    }
}
