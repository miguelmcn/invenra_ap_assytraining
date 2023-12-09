using assytraining.application.Domain;

namespace assytraining.application.Interfaces.Services.Activities
{
    public interface IActivityExecutionService
    {
        public Task Execute(Activity activity, string invenraStudentId);
    }
}
