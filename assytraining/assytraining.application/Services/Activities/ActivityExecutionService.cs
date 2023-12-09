using assytraining.application.Domain;
using assytraining.application.Interfaces.Services;
using assytraining.application.Interfaces.Services.Activities;

namespace assytraining.application.Services.Activities
{
    public class ActivityExecutionService(IActivityReaderService activityReaderService, IService<Analytics> analyticsService) : IActivityExecutionService
    {
        public Task Execute(Activity activity, string invenraStudentId)
        {
            // TODO: implement logic
            

            return Task.CompletedTask;
        }
    }
}
