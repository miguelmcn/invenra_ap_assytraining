using assytraining.application.Domain;

namespace assytraining.application.Interfaces.Services
{
    public interface IAnalyticsReportService
    {
        public Task<Analytics> GetReport(string activityId);
        public Task<Analytics> GetReport(string invenRAStudentID, string executionID);
    }
}
