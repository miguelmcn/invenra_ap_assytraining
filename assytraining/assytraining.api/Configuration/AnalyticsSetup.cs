using assytraining.application.Domain;
using assytraining.application.Interfaces.Repositories;
using assytraining.application.Interfaces.Services;
using assytraining.application.Services.Metrics;
using assytraining.infrastructure.Repositories;

namespace assytraining.api.Configuration
{
    public static class AnalyticsSetup
    {
        public static void SetupAnalyticsConfiguration(IServiceCollection services)
        {
            services.AddScoped<IService<Analytics>, AnalyticsService>();
            services.AddScoped<IRepository<Analytics>, AnalyticsRepository<Analytics>>();

            services.AddScoped<IAnalyticsReportService, AnalyticsReport>();
        }
    }
}
