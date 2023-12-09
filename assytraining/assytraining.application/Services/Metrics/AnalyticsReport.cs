using assytraining.application.Domain;
using assytraining.application.Interfaces.Services;

namespace assytraining.application.Services.Metrics
{
    public class AnalyticsReport(IService<Analytics> analyticsService) : IAnalyticsReportService
    {
        private readonly IService<Analytics> _analyticsService = analyticsService;

        public Task<Analytics> GetReport(string invenRAStudentID, string executionID)
        {
            // TODO: retrieve analytics
            throw new NotImplementedException();
        }

        public Task<Analytics> GetReport(string activityId)
        {
            throw new NotImplementedException();
        }
    }
}
